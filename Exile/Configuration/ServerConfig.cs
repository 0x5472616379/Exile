namespace Exile.Configuration;

public class ServerConfig
{
    public static int TICK_RATE = 600;
    public static int PORT = 43594;
    public static int MAX_PLAYERS = 2048;
    public static int MAX_NPCS = 8192;
    public static int BUFFER_SIZE = 4096;
    public static int PACKET_FETCH_LIMIT = 50;

    public static int SPAWN_LOCATION_X = 3245; //x = 3245 3512
                                               //y = 3225 3480
    public static int SPAWN_LOCATION_Y = 3225;
    public static int SPAWN_LOCATION_Z = 0;
    
    public static int ITEM_LIMIT = int.MaxValue;

    public static int BANK_SIZE = 300;
    public static int INVENTORY_SIZE = 28;

    public static bool ADDED_REGION_OBJECTS = false;
}