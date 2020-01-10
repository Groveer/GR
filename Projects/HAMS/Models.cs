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
  public class SqlContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(Global.DbSource);
    }
    public DbSet<Login> Logins { get; set; }
    public DbSet<User> Users { get; set; }
  }

  public class User
  {
    public int Id { get; set; }
    public string User_Id { get; set; }
    public string User_Name { get; set; }
    public string User_Sex { get; set; }
    public DateTime User_Birthday { get; set; }
    public string User_Phone { get; set; }
    public string User_HomePhone { get; set; }
    public string User_Email { get; set; }
    public string User_CardId { get; set; }
    public string User_Type { get; set; }
    public string House_Id { get; set; }

    public DateTime User_RecordDate { get; set; }
  }

}
