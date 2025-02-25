using Exile.Network.Client;

namespace Exile.Entities.Player;

public class Player : Entity
{
    public NetworkSession Session { get; set; }
    public PlayerAttributes Attributes { get; set; }
    public Player()
    {
        Session = new NetworkSession(this);
        Attributes = new PlayerAttributes();
    }
}