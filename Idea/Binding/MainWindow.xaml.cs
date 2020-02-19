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

namespace Binding
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
      dt.Columns.Add("ID", typeof(int));
      dt.Columns.Add("Name", typeof(string));
      dt.Columns.Add("PhoneNumber", typeof(string));
      dt.Columns.Add("Address", typeof(string));

      DataRow row = dt.NewRow();
      row["ID"] = 1;
      row["Name"] = "张三";
      row["PhoneNumber"] = "123456";
      row["Address"] = "北京";
      dt.Rows.Add(row);

      row = dt.NewRow();
      row["ID"] = 2;
      row["Name"] = "李四";
      row["PhoneNumber"] = "789001";
      row["Address"] = "上海";
      dt.Rows.Add(row);

      row = dt.NewRow();
      row["ID"] = 3;
      row["Name"] = "杨过";
      row["PhoneNumber"] = "586544";
      row["Address"] = "广州";
      dt.Rows.Add(row);

      CmbId.ItemsSource = dt.DefaultView;
      CmbId.DisplayMemberPath = "ID";
      CmbId.SelectedIndex = 0;

      TxtName.DataContext = CmbId.SelectedItem;
      TxtPhone.DataContext = CmbId.SelectedItem;
      TxtAddress.DataContext = CmbId.SelectedItem;
    }
    private void CmbId_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      TxtName.DataContext = CmbId.SelectedItem;
      TxtPhone.DataContext = CmbId.SelectedItem;
      TxtAddress.DataContext = CmbId.SelectedItem;
    }
  }
}
