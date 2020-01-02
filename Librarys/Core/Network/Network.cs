using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;


namespace GR
{
  public class Network
  {
    public static IPAddress GetLocalIp()
    {
      //Test
      IPHostEntry myEntry = Dns.GetHostEntry(Dns.GetHostName());
      return myEntry.AddressList.FirstOrDefault(e => e.AddressFamily.Equals(AddressFamily.InterNetwork));
    }
  }
}
