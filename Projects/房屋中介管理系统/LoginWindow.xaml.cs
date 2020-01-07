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
using System.Windows.Shapes;

namespace 房屋中介管理系统
{
  /// <summary>
  /// LoginWindow.xaml 的交互逻辑
  /// </summary>
  public partial class LoginWindow : Window
  {
    public LoginWindow()
    {
      InitializeComponent();
      var db = new LoginContext();
    }

    private void BtnLogin_Click(object sender, RoutedEventArgs e)
    {

    }

    private void BtnCancel_Click(object sender, RoutedEventArgs e)
    {
      Close();
    }
  }
}
