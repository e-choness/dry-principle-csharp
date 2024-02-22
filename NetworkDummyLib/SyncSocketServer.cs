using System.Net;
using System.Net.Sockets;
using System.Text;
using ExtensionsLibrary;

namespace NetworkDummyLib;

public class SyncSocketServer
{
    public static string? data = null;

    public static void StartListener()
    {
        var bytes = new byte[1024];

        var ipHost = Dns.GetHostEntry(Dns.GetHostName());
        var ipAddress = ipHost.AddressList[0];
        var localEndPoint = new IPEndPoint(ipAddress, 43665);
        var listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        
        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);
            while (true)
            {
                $"Waiting for a connecton....".Dump();
                var handler = listener.Accept();
                data = null;

                do
                {
                    var byteRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                } while (data.IndexOf("<EOF>", StringComparison.Ordinal) < 0);
            
                data.Dump("Text received: ");

                var msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
        }
        catch (Exception e)
        {
            e.Message.Dump();
        }

        "Server ends.".Dump();
    }
}