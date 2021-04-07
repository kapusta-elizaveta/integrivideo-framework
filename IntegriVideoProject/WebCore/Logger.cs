using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebCore
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger("LOGGER");
        
        public static ILog Log
        {
            get { return log; }
        }
 
        //Инициализация логера
        public static void InitLogger()
        { 
            BasicConfigurator.Configure();
        }
    }
}
