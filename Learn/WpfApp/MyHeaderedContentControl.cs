using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
  /// <summary>
  /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
  ///
  /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
  /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
  /// 元素中:
  ///
  ///     xmlns:MyNamespace="clr-namespace:WpfApp"
  ///
  ///
  /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
  /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根
  /// 元素中:
  ///
  ///     xmlns:MyNamespace="clr-namespace:WpfApp;assembly=WpfApp"
  ///
  /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
  /// 并重新生成以避免编译错误:
  ///
  ///     在解决方案资源管理器中右击目标项目，然后依次单击
  ///     “添加引用”->“项目”->[浏览查找并选择此项目]
  ///
  ///
  /// 步骤 2)
  /// 继续操作并在 XAML 文件中使用控件。
  ///
  ///     <MyNamespace:MyHeaderedContentControl/>
  ///
  /// </summary>
  public class MyHeaderedContentControl : ContentControl
  {
    static MyHeaderedContentControl()
    {
      DefaultStyleKeyProperty.OverrideMetadata(typeof(MyHeaderedContentControl), new FrameworkPropertyMetadata(typeof(MyHeaderedContentControl)));
    }
    #region Header
    /// <summary>
    /// 获取或设置Header的值
    /// </summary>
    public object Header
    {
      get => GetValue(HeaderProperty);
      set => SetValue(HeaderProperty, value);
    }
    /// <summary>
    /// 标识Header依赖属性
    /// </summary>
    public static readonly DependencyProperty HeaderProperty =
      DependencyProperty.Register(nameof(Header), typeof(object), typeof(MyHeaderedContentControl),
        new PropertyMetadata(default,OnHeaderChanged));

    private static void OnHeaderChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
    {
      if (e.OldValue == e.NewValue) return;
      var target = obj as MyHeaderedContentControl;
      target?.OnHeaderChanged(e.OldValue, e.NewValue);
    }

    protected virtual void OnHeaderChanged(object oldValue, object newValue)
    {

    }
    #endregion

    #region HeaderTemplate

    public object HeaderTemplate
    {
      get => GetValue(HeaderTemplateProperty);
      set => SetValue(HeaderTemplateProperty, value);
    }

    public static readonly DependencyProperty HeaderTemplateProperty =
      DependencyProperty.Register(nameof(HeaderTemplate), typeof(object), typeof(MyHeaderedContentControl),
        new PropertyMetadata(default, OnHeaderTemplateChanged));

    private static void OnHeaderTemplateChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
    {
      if (e.OldValue == e.NewValue) return;
      var target = obj as MyHeaderedContentControl;
      target?.OnHeaderTemplateChanged(e.OldValue, e.NewValue);
    }

    protected virtual void OnHeaderTemplateChanged(object oldValue,object newValue)
    {

    }

    #endregion
  }
}
