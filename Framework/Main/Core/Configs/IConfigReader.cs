using Framework.Main.Core.Enums;

namespace Framework.Main.Core.Configs
{
    interface IConfigReader
    {
        DriverType DriverType { get; }
        string URL { get; }
        int ImplicitWait { get; }
        int ExplicitWait { get; }
    }
}
