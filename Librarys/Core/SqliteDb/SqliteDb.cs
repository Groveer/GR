using System;
using System.Collections;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data;

namespace GR
{
  public class SqliteDb
  {
    #region 私有变量
    private SqliteConnection Conn { get; set; }
    private Hashtable Hashtb { get; set; }
    #endregion
    public SqliteDb()
    {
      string connStr = $"data source={Directory.GetCurrentDirectory()}/data.db";
      Conn = new SqliteConnection(connStr);
    }
    public SqliteDb(string connStr)
    {
      Conn = new SqliteConnection(connStr);
    }

    private void Open()
    {
      if (Conn.State.Equals(ConnectionState.Closed))
        Conn.Open();
    }
  }
}
