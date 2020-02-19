using System;
using System.Collections.Generic;
using System.Data;
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

namespace DataGrid背景问题
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      DataTable dt = new DataTable();
      dt.Columns.Add("A", typeof(string));
      dt.Columns.Add("B", typeof(string));
      DataRow row = dt.NewRow();
      row["A"] = "A1";
      row["B"] = "B1";
      dt.Rows.Add(row);
      row = dt.NewRow();
      row["A"] = "A2";
      row["B"] = "B2";
      dt.Rows.Add(row);
      DgTest.ItemsSource = dt.DefaultView;
    }
  }
}
