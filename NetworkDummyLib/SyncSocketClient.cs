using System.Net;
using System.Net.Sockets;
using System.Text;
using ExtensionsLibrary;

namespace NetworkDummyLib;

public class SyncSocketClient
{
    public static void StartClient()
    {
        byte[] bytes = new byte[1024];
        try
        {
            var hostName = Dns.GetHostName().Dump("Host:");
            var ipHost = Dns.GetHostEntry(hostName);
            var ip = ipHost.AddressList[0];
            var remoteEp = new IPEndPoint(ip, 43665);

            var sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sender.Connect(remoteEp);
                "Socket connected.".Dump();
                sender.RemoteEndPoint.ToString();
                var msg = "This is a tiny test."u8.ToArray();
                var byteSent = sender.Send(msg);
                var byteRec = sender.Receive(bytes);
                $"Echoed test {Encoding.ASCII.GetString(bytes, 0, byteRec)}".Dump();
                
                // Release the socket
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception e)
            {
                e.Message.Dump();
                if(e is ArgumentNullException) throw;
            }
        }
        catch (Exception e)
        {
            e.Message.Dump();
        }
    }
}