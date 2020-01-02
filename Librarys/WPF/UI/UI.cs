using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace GR
{
  /// <summary>
  /// UI���������
  /// </summary>
  public static class UI
  {
    public static Dispatcher Dispatcher = Dispatcher.CurrentDispatcher;
    /// <summary>
    /// ����Ч��
    /// </summary>
    /// <param name="ui">Ŀ��Ԫ��</param>
    public static void ShowUI(UIElement ui)
    {
      if (ui.Visibility != Visibility.Visible)
      {
        ui.Visibility = Visibility.Visible;
        DoubleAnimation daOpacity = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.3));
        ui.BeginAnimation(UIElement.OpacityProperty, daOpacity);
      }
    }
    /// <summary>
    /// ����Ч��
    /// </summary>
    /// <param name="ui">Ŀ��Ԫ��</param>
    public static void HiddenUI(UIElement ui)
    {
      if (ui.Visibility == Visibility.Visible)
      {
        DoubleAnimation daOpacity = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.3));
        daOpacity.Completed += (sr, ev) => ui.Visibility = Visibility.Collapsed;
        ui.BeginAnimation(UIElement.OpacityProperty, daOpacity);
      }
    }
    /// <summary>
    /// �첽����ͼƬ��Դ
    /// </summary>
    /// <param name="image">Ŀ��ͼƬ</param>
    /// <param name="path">��Դ·��</param>
    /// <param name="dispatcher">��ǰ�����̹߳�����</param>
    public static void SetImgSource(Image image, string path, Dispatcher dispatcher = null)
    {
      if (dispatcher != null) Dispatcher = dispatcher;
      if (System.IO.File.Exists(path))
        Dispatcher.BeginInvoke(() => image.Source = new BitmapImage(new Uri(path)));
    }
    /// <summary>
    /// �첽������Ƶ��Դ
    /// </summary>
    /// <param name="media">Ŀ����Ƶ�ؼ�</param>
    /// <param name="path">��Դ·��</param>
    /// <param name="dispatcher">��ǰ�����̹߳�����</param>
    public static void SetMdaSource(MediaElement media, string path, Dispatcher dispatcher = null)
    {
      if (dispatcher != null) Dispatcher = dispatcher;
      if (System.IO.File.Exists(path))
        Dispatcher.BeginInvoke(() => media.Source = new Uri(path));
    }
  }
}
