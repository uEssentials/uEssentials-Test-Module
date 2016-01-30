using Essentials.Api.Configuration;

namespace EssTestModule
{
    public class TestConfig : JsonConfig
    {
        public string Foo;

        public override void LoadDefaults()
        {
            Foo = "bar";
        }
    }
}