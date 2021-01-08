using Framework.Main.Core.Configs;
using Framework.Main.Core.Driver;
using Framework.Main.Core.Ioc;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Framework.Main.Core.UI.Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected IWebDriverManager manager = DIContainer.GetService<IWebDriverManager>();

        static BaseTest()
        {
            DIContainer.Register<IConfigReader, ConfigReader>(ServiceLifeTime.Singleton);
            DIContainer.Register<IWebDriverManager, WebDriverManager>(ServiceLifeTime.Singleton);
        }

        [SetUp]
        public void setUp()
        {
            manager.GetDriver().Manage().Window.Maximize();
        }

        [TearDown]
        public void tearDown()
        {
            manager.CleanUp();
        }
    }
}
