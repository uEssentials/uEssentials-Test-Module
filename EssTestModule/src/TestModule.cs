using Essentials.Modules;

namespace EssTestModule
{
    [ModuleInfo(
        Name = "TestModule",
        Author = "Leonardosc",
        Version = "1.0.0"
    )]
    public class TestModule : EssModule
    {
        public override void OnLoad()
        {
            Logger.LogInfo( "Loaded" );
        }

        public override void OnUnload()
        {
            Logger.LogInfo( "Unloaded" );
        }
    }
}
