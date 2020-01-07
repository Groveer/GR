using System;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      string[,] students =
      {
        {"张三","95001","95","97","87" },
        {"李四","95002","93","90","90" },
        {"王五","95003","89","92","86" },
      };
      string readStr=null;
      while (readStr!="Q"||readStr!="q")
      {
        readStr = Console.ReadLine();
        for (int i = 0; i < students.GetLength(0); i++)
        {
          if(students[i,1]== readStr)
          {
            double ave = (int.Parse(students[i, 2]) + 
              int.Parse(students[i, 3]) + int.Parse(students[i, 4])) / 3f;
            Console.WriteLine($"姓名：{students[i, 0]},学号：{readStr}," +
              $"数学成绩：{students[i, 2]},外语成绩：{students[i, 3]}," +
              $"C#成绩：{students[i, 4]},平均成绩：{ave}");
            break;
          }
          if(i== students.GetLength(0)-1)
            Console.WriteLine("该学号不存在，请重新输入学号！");
        }
      }
    }
  }
}
