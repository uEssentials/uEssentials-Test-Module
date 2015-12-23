using Essentials.Core.Event;
using Essentials.Unturned;
using Rocket.Unturned.Player;
namespace EssTestModule
{
    public class TestEventListener : IEventListener
    {
        [EventHandler( EventType.ROCKET_PLAYER_CONNECTED )]
        public void OnPlayerJoined( UnturnedPlayer player )
        {
            UPlayer.FromRocketPlayer( player ).SendMessage( "You joined :D", UnityEngine.Color.blue );
        }
    }
}
