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
    public static SqlContext Instance = new SqlContext();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite(Global.DbSource);
    }
    public DbSet<Login> Logins { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<House> Houses { get; set; }
  }

  public enum EUserType { Want,Lend}
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

  public class House
  {
    public int Id { get; set; }
    public string House_Id { get; set; }
    public string House_CompanyName { get; set; }
    public string House_TypeId { get; set; }
    public string House_SeatId { get; set; }
    public string House_State { get; set; }
    public string House_FitmentId { get; set; }
    public string House_FavorId { get; set; }
    public string House_MothedId { get; set; }
    public string House_Map { get; set; }
    public double House_Price { get; set; }
    public string House_FloorId { get; set; }
    public string House_BuildYear { get; set; }
    public string House_Area { get; set; }
    public string House_Remark { get; set; }
    public string User_Id { get; set; }
  }
}
