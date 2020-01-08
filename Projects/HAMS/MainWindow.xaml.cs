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

namespace HAMS
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      List<Group> grpLst = new List<Group>()
      {
        new Group(){ID=1,Name="用户信息管理",ParentId=0},
        new Group(){ID=2,Name="求租管理",ParentId=0},
        new Group(){ID=3,Name="员工信息",ParentId=0},
        new Group(){ID=4,Name="出租管理",ParentId=0},
        new Group(){ID=5,Name="交费管理",ParentId=0},
        new Group(){ID=6,Name="业务统计",ParentId=0},
        new Group(){ID=7,Name="常用工具",ParentId=0},
        new Group(){ID=8,Name="系统管理",ParentId=0},
        new Group(){ID=9,Name="帮助",ParentId=0},
        new Group(){ID=10,Name="求租人员信息设置",ParentId=1},
        new Group(){ID=11,Name="出租人员信息设置",ParentId=1},
        new Group(){ID=12,Name="人员信息控制",ParentId=1},
        new Group(){ID=13,Name="房源查询设置",ParentId=2},
        new Group(){ID=14,Name="房源状态浏览",ParentId=2},
        new Group(){ID=15,Name="求租意向设置",ParentId=2},
        new Group(){ID=16,Name="录入员工信息",ParentId=3},
        new Group(){ID=17,Name="所有员工信息",ParentId=3},
        new Group(){ID=18,Name="房型信息设置",ParentId=4},
        new Group(){ID=19,Name="楼层设置",ParentId=4},
        new Group(){ID=20,Name="栋/座设置",ParentId=4},
        new Group(){ID=21,Name="装修程度设置",ParentId=4},
        new Group(){ID=22,Name="朝向设置",ParentId=4},
        new Group(){ID=23,Name="用途设置",ParentId=4},
        new Group(){ID=24,Name="收费设置",ParentId=5},
        new Group(){ID=25,Name="收费记录",ParentId=5},
        new Group(){ID=26,Name="成交业务量统计",ParentId=6},
        new Group(){ID=27,Name="计算器",ParentId=7},
        new Group(){ID=28,Name="记事本",ParentId=7},
        new Group(){ID=29,Name="口令设置",ParentId=8},
        new Group(){ID=30,Name="推出系统",ParentId=8},
        new Group(){ID=31,Name="清理无效信息",ParentId=8},
        new Group(){ID=32,Name="帮助文件",ParentId=9}
      };
      var tmpLst= GetTreeData(0, grpLst);
      MenuMain.ItemsSource = tmpLst;
      TvMenu.ItemsSource = tmpLst;
    }
    /// <summary>
    /// 递归生成树形数据
    /// </summary>
    /// <param name="delst"></param>
    /// <returns></returns>
    private List<Group> GetTreeData(int parentid, List<Group> nodes)
    {
      List<Group> mainNodes = nodes.Where(x => x.ParentId == parentid).ToList();
      List<Group> otherNodes = nodes.Where(x => x.ParentId != parentid).ToList();
      foreach (Group grp in mainNodes)
      {
        grp.Nodes = GetTreeData(grp.ID, otherNodes);
      }
      return mainNodes;
    }
    private class Group
    {
      public Group()
      {
        this.Nodes = new List<Group>();
        this.ParentId = 0;//主节点的父id默认为0
      }

      public List<Group> Nodes { get; set; }
      public int ID { get; set; }//id
      public int ParentId { get; set; }//parentID
      public string Name { get; set; }
    }
  }
}
