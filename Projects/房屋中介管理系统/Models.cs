using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace 房屋中介管理系统
{
  public static class Global
  {
    public static string DbSource = $"Data Source={System.IO.Directory.GetCurrentDirectory()}/Data.db";
  }
  public class Login
  {
    public int Id { get; set; }
    public string Login_Id { get; set; }
    public string Employee_Id { get; set; }
    public string Login_Name { get; set; }
    public string Login_Pwd { get; set; }
    public string Login_Power { get; set; }
  }
  public class LoginContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Filename=Data.db");
    }
    public DbSet<Login> Logins { get; set; }
  }
}
