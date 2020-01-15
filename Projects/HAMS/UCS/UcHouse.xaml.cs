using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HAMS.UCS
{
  /// <summary>
  /// UcHouse.xaml 的交互逻辑
  /// </summary>
  public partial class UcHouse : UserControl
  {
    public UcHouse()
    {
      InitializeComponent();
      GrpMsg.Visibility = Visibility.Hidden;
    }

    private void BtnCancel_Click(object sender, RoutedEventArgs e)
    {
      if(Parent is UniformGrid grid)
      {
        grid.Children.Clear();
      }
    }

    private void BtnType_Click(object sender, RoutedEventArgs e)
    {
      

    }
  }
}
