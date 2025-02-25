using Exile.Configuration;
using Exile.Constants;
using Exile.Entities.Player;
using Exile.Util;

namespace Exile.Network;

public class PacketBuilder
{
    private readonly Player _player;

    public PacketBuilder(Player player)
    {
        _player = player;
    }

    public void BuildNewBuildAreaPacket()
    {
        _player.Session.Writer.CreateFrame(ServerOpCodes377.REGION_LOAD);
        _player.Session.Writer.WriteWord(_player.Location.OffsetChunkY + 6);
        _player.Session.Writer.WriteWordBigEndianA(_player.Location.OffsetChunkX + 6);
    }

    public void DisplayWelcomeScreen()
    {
        _player.Session.Writer.CreateFrame(ServerOpCodes377.INTF_WELCOME);
        _player.Session.Writer.WriteByteC(201); //daysSinceRecoveryChange
        _player.Session.Writer.WriteWordA(1); //unreadMessages
        _player.Session.Writer.WriteByte(0); //membership
        _player.Session.Writer.WriteDWordV2(IPAddressConverter.ConvertToInt("127.0.0.1")); //lastAddress
        _player.Session.Writer.WriteWordA(128); //daysSinceLogin
    }
    
    public void SendMessage(string message)
    {
        _player.Session.Writer.CreateFrameVarSize(ServerOpCodes377.MSG_SEND);
        _player.Session.Writer.WriteString($"{message}");
        _player.Session.Writer.EndFrameVarSize();
    }
}