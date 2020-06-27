using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace WebDriverTasks
{
    // Enum for browserType
    public enum BrowerType
    {
        Chrome, Firefox, IE
    }

    public class Hooks : Base
    {
        private BrowerType _browserType;


        public Hooks(BrowerType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                driver = new ChromeDriver(@"C:\Users\user\source\repos\SeleniumJenkins\Drivers");

            else if (browserType == BrowerType.Firefox)
            {
                driver = new FirefoxDriver(@"C:\Users\user\source\repos\SeleniumJenkins\Drivers");
            }
        }
    }
}
