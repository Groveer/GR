using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      List<int> lst = new List<int>()
      {
        1,2,4,3,5,8
      };
      //Lbx.ItemsSource = lst;
      foreach(var n in lst)
      {
        Lbx.Items.Add(n);
      }
      Lbx.SelectedItem = 2;
    }
  }
}
