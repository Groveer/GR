using System;

namespace ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      A.a = 10;
      A a = new A();
    }

  }
  public class A
  {
    public static int a;
  }
}
