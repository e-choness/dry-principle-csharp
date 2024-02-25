using System.Net;
using System.Net.Sockets;
using System.Text;
using ExtensionsLibrary;

namespace NetworkDummyLib;

public class AsyncSocketServer
{
    public static async Task StartListenerAsync()
    {
        var ipHost = await Dns.GetHostEntryAsync(Dns.GetHostName());
        var ipAddress = ipHost.AddressList[0];
        ipAddress.ToString().Dump("Server ip: ");
        var localEndPoint = new IPEndPoint(ipAddress, SharedData.Port);

        var listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            listener.Bind(localEndPoint);
            listener.Listen(10);
            "Server is listening to connections...".Dump();

            while (true)
            {
                var handler = await listener.AcceptAsync();
                _ = HandleClientAsync(handler);
            }
        }
        catch (Exception e)
        {
            e.Message.Dump("Error: ");
        }
        finally
        {
            listener.Close();
        }
    }

    private static async Task HandleClientAsync(Socket handler)
    {
        try
        {
            $"Connecting to {handler.RemoteEndPoint}".Dump();
            var receivedData = await ReceiveDataAsync(handler);

            receivedData.Dump("Text received: ");

            var sendData = Encoding.ASCII.GetBytes(receivedData);
            await handler.SendAsync(sendData, SocketFlags.None);

            handler.RemoteEndPoint.ToString().Dump("Data sent back to: ");
            
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();

        }
        catch (Exception e)
        {
            e.Message.Dump("Error: ");
        }
    }

    private static async Task<string> ReceiveDataAsync(Socket handler)
    {
        var dataBuffer = new byte[1024];
        var receivedData = new StringBuilder();

        while (true)
        {
            var byteRead = await handler.ReceiveAsync(new ArraySegment<byte>(dataBuffer), SocketFlags.None);

            if (byteRead == 0) break;

            receivedData.Append(Encoding.ASCII.GetString(dataBuffer, 0, byteRead));

            if (receivedData.ToString().IndexOf(SharedData.EOFMarker, StringComparison.Ordinal) >= 0) break;
        }

        return receivedData.ToString();
    }
}