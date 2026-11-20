using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;

namespace WelcomePlugin;

public class WelcomePlugin : BasePlugin
{
    public override string ModuleName => "Welcome Plugin";
    public override string ModuleVersion => "1.0.0";
    public override string ModuleAuthor => "Nicholas";
    public override string ModuleDescription => "Welcomes players when they join";

    public override void Load(bool hotReload)
    {
        RegisterEventHandler<EventPlayerConnectFull>((@event, info) =>
        {
            var player = @event.Userid;
            if (player != null && player.IsValid)
            {
                Server.PrintToChatAll($"Welcome {player.PlayerName} to the server! Enjoy your stay!");
            }
            return HookResult.Continue;
        });
    }
}
