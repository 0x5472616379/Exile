namespace Exile.Constants.Appearance;

[Flags]
public enum PlayerUpdateFlags
{
    None = 0,
    Appearance = 0x04,
    Chat = 0x02,
    Graphics = 0x04,
    Animation = 0x8,
    ForceChat = 0x10,
    FaceEntity = 0x20,
    FaceDirection = 0x40,
    SingleHit = 0x80,
    DoubleHit = 0x100,
    
    FullMask = 0x20 //0x140
}