using Exile.Constants.Appearance;

namespace Exile.Entities.Player;

public class PlayerAttributes
{
    public Gender Gender { get; set; } = Gender.Male;
    public HeadIcon HeadIcon { get; set; } = HeadIcon.None;
    public PlayerRights Rights { get; set; } = PlayerRights.NORMAL;
}