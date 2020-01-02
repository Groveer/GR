using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace GR
{
  /// <summary>
  /// 序列帧播放相关类
  /// </summary>
  public class ImgPlayer
  {
    /// <summary>
    /// 要进行播放的UI管理线程
    /// </summary>
    public Dispatcher Dispatcher
    {
      get { return UI.Dispatcher; }
      set { UI.Dispatcher = value; }
    }
    /// <summary>
    /// 需要播放的图片
    /// </summary>
    public Image Image { get; set; }
    /// <summary>
    /// 是否循环播放
    /// </summary>
    public int Loops { get; set; }
    /// <summary>
    /// 当前图片索引
    /// </summary>
    private int CurImgIndex { get; set; }
    /// <summary>
    /// 当前播放次数
    /// </summary>
    private int CurloopIndex { get; set; }
    /// <summary>
    /// 存放资源
    /// </summary>
    private BitmapImage[] Bitmaps;
    /// <summary>
    /// 计时器
    /// </summary>
    private Timer Timer { get; set; }

    /// <summary>
    /// 图片播放完毕触发事件
    /// </summary>
    public event Action<object> ImgEnded;
    /// <summary>
    /// ImgPLayer初始化
    /// </summary>
    /// <param name="dispatcher">UI管理线程</param>
    /// <param name="img">播放图片控件</param>
    /// <param name="path">播放路径</param>
    /// <param name="imgExtension">图片后缀名</param>
    /// <param name="loops">循环次数，为0则无限循环</param>
    /// <param name="milliscds">帧率，默认25毫秒1帧</param>
    public ImgPlayer(Image img, string path, string imgExtension = "jpg", int loops = 0, double milliscds = 25, Dispatcher dispatcher = null)
    {
      if (dispatcher != null) Dispatcher = dispatcher;
      Image = img;
      Loops = loops;
      CurImgIndex = 0;
      CurloopIndex = 0;
      SetPath(path, imgExtension);
      SetTimer(milliscds);
    }

    /// <summary>
    /// 设置图片路径
    /// </summary>
    /// <param name="path">图片路径</param>
    /// <param name="imgExtension">图片后缀名</param>
    public void SetPath(string path, string imgExtension = "jpg")
    {
      if (System.IO.Directory.Exists(path))
      {
        string[] files = System.IO.Directory.GetFiles(path, $"*.{imgExtension}");
        Bitmaps = new BitmapImage[files.Length];
        for (int i = 0; i < files.Length; i++)
        {
          Bitmaps[i] = new BitmapImage(new Uri(files[i]));
        }
      }
    }

    /// <summary>
    /// 设置帧率 单位毫秒
    /// </summary>
    /// <param name="milliscds">目标毫秒数</param>
    public void SetTimer(double milliscds)
    {
      Timer = new Timer(milliscds);
      Timer.Elapsed += Timer_Elapsed;
      Timer.AutoReset = true;
    }
    /// <summary>
    /// 开始
    /// </summary>
    public void Start()
    {
      Timer.Enabled = true;
    }
    /// <summary>
    /// 暂停
    /// </summary>
    public void Pause()
    {
      Timer.Enabled = false;
    }
    /// <summary>
    /// 停止
    /// </summary>
    public void Stop()
    {
      Timer.Enabled = false;
      CurImgIndex = 0;
      CurloopIndex = 0;
    }
    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
      Dispatcher.BeginInvoke(() => Image.Source = Bitmaps[CurImgIndex]);
      CurImgIndex++;
      if (CurImgIndex >= Bitmaps.Length)
      {
        ImgEnded?.Invoke(this);
        CurImgIndex = 0;
        if (Loops > 0)
        {
          if (CurloopIndex >= Loops)
            Stop();
          CurloopIndex++;
        }
      }
    }

    ~ImgPlayer()
    {
      Stop();
      Timer.Close();
      Array.Clear(Bitmaps, 0, Bitmaps.Length);
      GC.Collect();
    }

  }
}
