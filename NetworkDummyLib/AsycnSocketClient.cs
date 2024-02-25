using System.Net;
using System.Net.Sockets;
using System.Text;
using ExtensionsLibrary;

namespace NetworkDummyLib;

public class AsycnSocketClient
{
    public static async Task StartClientAsync()
    {
        try
        {
            var ipHost = await Dns.GetHostEntryAsync(Dns.GetHostName());
            var ipAddress = ipHost.AddressList.FirstOrDefault(address => address.IsIPv6LinkLocal);
            // ipAddress.ToString().Dump("Client ip: ");
            var remoteEndPoint = new IPEndPoint(ipAddress, SharedData.Port);

            using var sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            await sender.ConnectAsync(remoteEndPoint);

            sender.RemoteEndPoint.Dump("Connected to: ");

            var message = $"This is a tiny test.{SharedData.EOFMarker}";

            var byteSent = await sender.SendAsync(Encoding.ASCII.GetBytes(message));

            byteSent.Dump("Number of bytes has been sent to the server: ");

            var bytes = new byte[1024];
            var byteReceived = await sender.ReceiveAsync(bytes);
            var receivedData = Encoding.ASCII.GetString(bytes, 0, byteReceived);

            receivedData.Dump("Echoed test: ");

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
        catch (Exception e)
        {
            e.Message.Dump();
        }
    }
}