using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using NetSDKCS;

namespace Capture
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    private IntPtr _LoginID = IntPtr.Zero;
    private IntPtr _PlayID = IntPtr.Zero;
    private fSnapRevCallBack _SnapRevCallBack;
    private NET_DEVICEINFO_Ex _DeviceInfo = new NET_DEVICEINFO_Ex();
    //private bool _IsSpanCapture = false;
    public MainWindow()
    {
      InitializeComponent();
      Loaded += MainWindow_Loaded;
      Unloaded += MainWindow_Unloaded;
      MouseDown += MainWindow_MouseDown;
      try
      {
        _SnapRevCallBack = new fSnapRevCallBack(SnapRevCallBack);
        NETClient.Init(null, IntPtr.Zero, null);
        NETClient.SetSnapRevCallBack(_SnapRevCallBack, IntPtr.Zero);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        Close();
      }
    }

    private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
    {
      if(IntPtr.Zero==_LoginID)
      {
        HwndSource hs = (HwndSource)PresentationSource.FromDependencyObject(ImgPreview);
        InitSdk(hs.Handle);
      }
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      
    }

    private void MainWindow_Unloaded(object sender, RoutedEventArgs e)
    {
      NETClient.Cleanup();
    }

    private void SnapRevCallBack(IntPtr lLoginID, IntPtr pBuf, uint RevLen, uint EncodeType, uint CmdSerial, IntPtr dwUser)
    {
      string path = AppDomain.CurrentDomain.BaseDirectory + "image";
      if (!System.IO.Directory.Exists(path))
      {
        System.IO.Directory.CreateDirectory(path);
      }
      if (EncodeType == 10) //.jpg
      {
        DateTime now = DateTime.Now;
        //string fileName = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second) + ".jpg";
        //string filePath = path + "\\" + fileName;
        byte[] data = new byte[RevLen];
        Marshal.Copy(pBuf, data, 0, (int)RevLen);
        //try
        //{
        //  //when the file is operate by local capture will throw expection.
        //  using (System.IO.FileStream stream = new System.IO.FileStream(filePath, System.IO.FileMode.OpenOrCreate))
        //  {
        //    stream.Write(data, 0, (int)RevLen);
        //    stream.Flush();
        //    stream.Dispose();
        //  }
        //}
        //catch
        //{
        //  return;
        //}
        Dispatcher.BeginInvoke(() =>{
          BitmapImage bitmap = new BitmapImage();
          bitmap.BeginInit();
          bitmap.StreamSource = new System.IO.MemoryStream(data);
          bitmap.EndInit();
          ImgPreview.Source = bitmap;
        });
      }
    }
    private void InitSdk(IntPtr hwnd)
    {
      ushort port = 37777;
      string ip = "192.168.1.108";
      string user = "admin";
      string pwd = "cube1234";
      _LoginID = NETClient.Login(ip, port, user, pwd, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref _DeviceInfo);
      if (IntPtr.Zero == _LoginID)
      {
        MessageBox.Show(NETClient.GetLastError());
        return;
      }
      _PlayID = NETClient.RealPlay(_LoginID, 1, hwnd);
      if (IntPtr.Zero == _PlayID)
      {
        MessageBox.Show(NETClient.GetLastError());
        return;
      }

    }
  }
}
