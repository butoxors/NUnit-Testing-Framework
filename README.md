# NUnit-Testing-Framework
## Project structure:
- Framework - **Framework core lib**
  - Main
    - Core
      - Driver - **WebDriver set up**
      - Enums - **Framework enums**
        - Constants - **Framework constants**
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
  - Run tests via 'Visual Studio -> Test Explorer'.

## Versions:
ChromeDriver version is 87.0.4280.88

## To do:
  - Implement page decoration;
  - Config readers;
  - Logging;
  - Report;
  - etc.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.
