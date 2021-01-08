using Framework.Main.Core.Enums;
using Framework.Main.Core.Ioc;
using Framework.Main.Core.Utils;
using System.Configuration;

namespace Framework.Main.Core.Configs
{
    public class ConfigReader : IConfigReader
    {
        public DriverType DriverType => DriverConverter.Convert(ConfigurationManager.AppSettings["driver"]);

        public string URL => ConfigurationManager.AppSettings["url"];

        public int ImplicitWait => int.Parse(ConfigurationManager.AppSettings["implicitWait"]);

        public int ExplicitWait => int.Parse(ConfigurationManager.AppSettings["explicitWaiter"]);
    }
}
