﻿using System;
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
      for(int i=0;i<10;i++)
      {
        Rectangle rect = new Rectangle
        {
          Margin=new Thickness(5),
          Width = 60,
          Height = 40,
          Fill = Brushes.Blue
        };
        Wpl.Children.Add(rect);
      }
    }
    
  }
}
