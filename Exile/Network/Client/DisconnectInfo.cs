using Exile.Entities.Player;

namespace Exile.Network.Client;

public class DisconnectInfo
{
    public DisconnectInfo(Player player, string reason)
    {
        Player = player;
        Reason = reason;
    }

    public Player Player { get; }
    public string Reason { get; }
}