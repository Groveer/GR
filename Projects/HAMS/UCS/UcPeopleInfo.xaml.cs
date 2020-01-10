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

namespace HAMS.UCS
{
  /// <summary>
  /// UcPeopleInfo.xaml 的交互逻辑
  /// </summary>
  public partial class UcPeopleInfo : UserControl
  {
    public string UserType { get;set; }//只有出租人和求租人两种类型
    public UcPeopleInfo()
    {
      InitializeComponent();
    }

    private void UserControl_Loaded(object sender, RoutedEventArgs e)
    {
      if (UserType == "求租人")
        BtnInputHouse.Visibility = Visibility.Collapsed;
      else
        BtnInputHouse.Visibility = Visibility.Visible;
    }
  }
}
