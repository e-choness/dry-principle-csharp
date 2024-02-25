using System.Net;
using System.Net.Sockets;
using System.Text;
using ExtensionsLibrary;

namespace NetworkDummyLib;

public class SyncSocketServer
{
    private static string? _data;

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
                "Server is listening for connections....".Dump();
                var handler = listener.Accept();
                _data = null;

                do
                {
                    var byteRec = handler.Receive(bytes);
                    _data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                } while (_data.IndexOf(SharedData.EOFMarker, StringComparison.Ordinal) < 0);
            
                _data.Dump("Text received: ");

                var msg = Encoding.ASCII.GetBytes(_data);
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