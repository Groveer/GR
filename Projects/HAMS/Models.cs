using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HAMS
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
      optionsBuilder.UseSqlite(Global.DbSource);
    }
    public DbSet<Login> Logins { get; set; }
  }
}
