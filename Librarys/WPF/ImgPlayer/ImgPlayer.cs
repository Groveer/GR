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
  /// ����֡���������
  /// </summary>
  public class ImgPlayer
  {
    /// <summary>
    /// Ҫ���в��ŵ�UI�����߳�
    /// </summary>
    public Dispatcher Dispatcher
    {
      get { return UI.Dispatcher; }
      set { UI.Dispatcher = value; }
    }
    /// <summary>
    /// ��Ҫ���ŵ�ͼƬ
    /// </summary>
    public Image Image { get; set; }
    /// <summary>
    /// �Ƿ�ѭ������
    /// </summary>
    public int Loops { get; set; }
    /// <summary>
    /// ��ǰͼƬ����
    /// </summary>
    private int CurImgIndex { get; set; }
    /// <summary>
    /// ��ǰ���Ŵ���
    /// </summary>
    private int CurloopIndex { get; set; }
    /// <summary>
    /// �����Դ
    /// </summary>
    private BitmapImage[] Bitmaps;
    /// <summary>
    /// ��ʱ��
    /// </summary>
    private Timer Timer { get; set; }

    /// <summary>
    /// ͼƬ������ϴ����¼�
    /// </summary>
    public event Action<object> ImgEnded;
    /// <summary>
    /// ImgPLayer��ʼ��
    /// </summary>
    /// <param name="dispatcher">UI�����߳�</param>
    /// <param name="img">����ͼƬ�ؼ�</param>
    /// <param name="path">����·��</param>
    /// <param name="imgExtension">ͼƬ��׺��</param>
    /// <param name="loops">ѭ��������Ϊ0������ѭ��</param>
    /// <param name="milliscds">֡�ʣ�Ĭ��25����1֡</param>
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
    /// ����ͼƬ·��
    /// </summary>
    /// <param name="path">ͼƬ·��</param>
    /// <param name="imgExtension">ͼƬ��׺��</param>
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
    /// ����֡�� ��λ����
    /// </summary>
    /// <param name="milliscds">Ŀ�������</param>
    public void SetTimer(double milliscds)
    {
      Timer = new Timer(milliscds);
      Timer.Elapsed += Timer_Elapsed;
      Timer.AutoReset = true;
    }
    /// <summary>
    /// ��ʼ
    /// </summary>
    public void Start()
    {
      Timer.Enabled = true;
    }
    /// <summary>
    /// ��ͣ
    /// </summary>
    public void Pause()
    {
      Timer.Enabled = false;
    }
    /// <summary>
    /// ֹͣ
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
