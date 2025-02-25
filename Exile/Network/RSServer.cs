using Exile.Configuration;
using Exile.Util;

namespace Exile.Network;

public class RSServer
{
    private bool _isRunning;

    public void Run()
    {
        _isRunning = true;
        
        ConnectionManager.Initialize();
        
        if (!Kernel.TryGetFrequency(out long frequency))
        {
            Console.WriteLine("High-resolution performance counter not supported.");
            return;
        }

        Kernel.InitializeTick(frequency, ServerConfig.TICK_RATE);

        while (_isRunning)
        {
            Kernel.StartTick();
            
            ConnectionManager.AcceptClients();
            
            Kernel.WaitForNextTick();
            Kernel.WarnIfTickExceeded();
            
            Kernel.PrintTickDuration();
        }
    }
}