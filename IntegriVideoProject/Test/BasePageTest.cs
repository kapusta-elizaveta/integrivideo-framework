using NUnit.Framework;
using WebCore;

namespace IntegriVideoProject.Test
{
    [TestFixture]
    //[AllureNUnit]
    //[AllureDisplayIgnored]
    public class BasePageTest
    {
        public Browser _browser;
        
        [TearDown]
        public void TearDown()
        {
           Browser.Current.Dispose();
        }
    }
}

