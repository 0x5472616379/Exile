using Exile.Configuration;
using Exile.Environment;

namespace Exile.Entities;

public abstract class Entity
{
    public Location Location { get; set; } = new(ServerConfig.SPAWN_LOCATION_X,
                                                 ServerConfig.SPAWN_LOCATION_Y,
                                                 ServerConfig.SPAWN_LOCATION_Z);
}