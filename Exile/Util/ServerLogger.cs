using System.Net;
using System.Net.Sockets;

namespace Exile.Util;

public class ServerLogger
{
    public static void WarnAboutTickExceeded(double tickDuration)
    {
        Console.WriteLine($"Warning: Tick duration exceeded! Took {tickDuration:F2} ms.");
    }
    
    public static void PrintTickDuration(double lastTickDurationMs)
    {
        Console.WriteLine($"Total tick duration: {lastTickDurationMs:F2} ms");
    }

    public static void IncomingConnectionMessage(TcpClient tcpClient)
    {
        Console.WriteLine($"Incoming Connection From: {((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString()}");
    }
}