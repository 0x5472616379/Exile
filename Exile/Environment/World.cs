using Exile.Configuration;
using Exile.Entities;
using Exile.Entities.Player;
using Exile.Managers;

namespace Exile.Environment;

public class World
{
    private static Entity[] NPCs = new Entity[ServerConfig.MAX_NPCS];
    
    private static Player[] Players = new Player[ServerConfig.MAX_PLAYERS];

    public static void Process()
    {
        CollectPlayerPackets();
        PlayerUpdateManager.Update();
        FlushAllPlayers();
        ResetAllPlayers();
    }

    private static void CollectPlayerPackets()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i] == null) continue;

            for (var n = 0; n < ServerConfig.PACKET_FETCH_LIMIT; n++)
                Players[i].Session.Fetch();
        }
    }
    
    
    public static void AddPlayer(Entity player)
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i] == null)
            {
                Players[i] = (Player)player;
                break;
            }
        }
    }
    
    public static void RemovePlayer(Entity player)
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i] == player)
            {
                for (int j = i; j < Players.Length - 1; j++)
                    Players[j] = Players[j + 1];

                break;
            }
        }
    }
    
    private static void ResetAllPlayers()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i] == null) continue;
            Players[i].Reset();
        }
    }
    
    private static void FlushAllPlayers()
    {
        for (int i = 0; i < Players.Length; i++)
        {
            if (Players[i] == null) continue;
            Players[i].Session.Flush();
        }
    }
    
    public static Player[] GetPlayers() => Players;
    public static int GetPlayerCount() => Players.Count(x => x != null);
}