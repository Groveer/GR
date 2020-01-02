using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace GR
{
  /// <summary>
  /// UI操作相关类
  /// </summary>
  public static class UI
  {
    public static Dispatcher Dispatcher = Dispatcher.CurrentDispatcher;
    /// <summary>
    /// 淡入效果
    /// </summary>
    /// <param name="ui">目标元素</param>
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
    /// 淡出效果
    /// </summary>
    /// <param name="ui">目标元素</param>
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
    /// 异步设置图片资源
    /// </summary>
    /// <param name="image">目标图片</param>
    /// <param name="path">资源路径</param>
    /// <param name="dispatcher">当前工作线程管理器</param>
    public static void SetImgSource(Image image, string path, Dispatcher dispatcher = null)
    {
      if (dispatcher != null) Dispatcher = dispatcher;
      if (System.IO.File.Exists(path))
        Dispatcher.BeginInvoke(() => image.Source = new BitmapImage(new Uri(path)));
    }
    /// <summary>
    /// 异步设置视频资源
    /// </summary>
    /// <param name="media">目标视频控件</param>
    /// <param name="path">资源路径</param>
    /// <param name="dispatcher">当前工作线程管理器</param>
    public static void SetMdaSource(MediaElement media, string path, Dispatcher dispatcher = null)
    {
      if (dispatcher != null) Dispatcher = dispatcher;
      if (System.IO.File.Exists(path))
        Dispatcher.BeginInvoke(() => media.Source = new Uri(path));
    }
  }
}
