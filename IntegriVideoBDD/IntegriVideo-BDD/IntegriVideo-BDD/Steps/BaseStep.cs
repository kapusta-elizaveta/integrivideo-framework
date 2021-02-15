using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WebCore;

namespace IntegriVideo_BDD.Steps
{
    public class BaseStep
    {
        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Current.Dispose();
        }
    }
}
