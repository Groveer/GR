using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGrid与TextBox数据绑定
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      ObservableCollection<Data> datas = new ObservableCollection<Data>
      {
        new Data(){A="A1",B="B1",C="C1",D="D1"},
        new Data(){A="A2",B="B2",C="C2",D="D2"},
        new Data(){A="A3",B="B3",C="C3",D="D3"},
        new Data(){A="A4",B="B4",C="C4",D="D4"}
      };
      DgTest.ItemsSource = datas;
    }

    private void DgTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      TbxTest.DataContext = DgTest.SelectedItem;
    }
  }
  public class Data
  {
    public string A { get; set; }
    public string B { get; set; }
    public string C { get; set; }
    public string D { get; set; }
  }
}
