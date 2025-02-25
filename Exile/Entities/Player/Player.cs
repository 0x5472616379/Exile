using Exile.Constants.Appearance;
using Exile.Managers;
using Exile.Network;
using Exile.Network.Client;

namespace Exile.Entities.Player;

public class Player : Entity
{
    public NetworkSession Session { get; set; }
    public Player[] LocalPlayers { get; set; } = new Player[255];
    public bool PerformedTeleport { get; set; }
    public PlayerAttributes Attributes { get; set; }
    public PacketBuilder PacketBuilder { get; set; }
    public PlayerUpdateFlags Flags { get; set; }
    
    public EquipmentManager EquipmentManager { get; set; }
    public ColorManager ColorManager { get; set; }
    public AnimationManager AnimationManager { get; set; }
    
    public Player()
    {
        Session = new NetworkSession(this);
        PacketBuilder = new PacketBuilder(this);
        Attributes = new PlayerAttributes();

        EquipmentManager = new EquipmentManager(this);
        ColorManager = new ColorManager();
        AnimationManager = new AnimationManager();
        
        Flags = PlayerUpdateFlags.None;
        
    }
    
    public void AddLocalPlayer(Entity player)
    {
        for (int i = 0; i < LocalPlayers.Length; i++)
        {
            if (LocalPlayers[i] == null)
            {
                LocalPlayers[i] = (Player)player;
                break;
            }
        }
    }
    
    public void RemoveLocalPlayer(Entity player)
    {
        for (int i = 0; i < LocalPlayers.Length; i++)
        {
            if (LocalPlayers[i] == player)
            {
                for (int j = i; j < LocalPlayers.Length - 1; j++)
                    LocalPlayers[j] = LocalPlayers[j + 1];

                break;
            }
        }
    }
    
    public void Reset()
    {
        PerformedTeleport = false;
        Flags = PlayerUpdateFlags.None;
        
        // MovementHandler.PrimaryDirection = -1;
        // MovementHandler.SecondaryDirection = -1;
        // MovementHandler.IsRunning = false;
        // MovementHandler.IsWalking = false;
        // MovementHandler.DiscardMovementQueue = false;
        //
        // CurrentAnimation = -1;
        // CurrentGfx = -1;
    }
}