# NUnit-Testing-Framework
## Project structure:
- Framework - **Framework core lib**
  - Main
    - Core
      - Advices - **Proxy wrappers**
      - Attributes - **Custom attributes**
      - Configs - **Config readers**
      - Driver - **WebDriver set up**
      - Enums - **Framework enums**
      - Test - **Tests structure**
      - UI
        - Models - **Data models**
        - Pages - **Pages structure**
      - Utils - **Framework utils**
- Tests - **Tests**
  - Resources - **Testing resources**
  - Tests - **Test folder**
  - UI
    - Pages - **Pages implementation**

## How to use:
  - Clone the project;
  - Check all required dependencies:
    - Framework:
      - NUnit;
      - Selenium.Support;
      - Selenium.WebDriver.
    - Tests:
      - NUnit;
      - NUnit3TestAdapter;
      - Selenium.Support;
      - Selenium.WebDriver.
  - Check *Framework.Main.Core.Driver.Factory.CreateDriver(DriverType type)* to resources includes *chromedriver.exe*
  - *Tests\Configs\App.config* is to use static configurable properies
  - Run tests via *'Visual Studio -> Test Explorer'*.
## Versions:
ChromeDriver version is *87.0.4280.88*

## To do:
  - ~~Implement page decoration~~ - 08.01.2021;
  - ~~Config readers;~~
  - Logging;
  - Report;
  - Ioc;
  - etc.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.
