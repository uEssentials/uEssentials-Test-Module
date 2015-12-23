using Essentials.Core.Command;
using Essentials.Unturned;

namespace EssTestModule
{
    [CommandInfo(
        Name = "teest",
        Description = "Just an test",
        Target = CommandTarget.BOTH, // default
        Usage = "<msg>",
        Permission = "my.module.teest"
    )]
    public class TestCommand : EssCommand
    {
        public override void OnExecute( ICommandSource source, ICommandArgs parameters )
        {
            if ( parameters.IsEmpty )
            {
                source.SendMessage( "Hi :D" );
            }
            else
            {
                UServer.Broadcast( parameters.GetJoinedArguments( 0 ) );
            }
        }
    }
}
