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
       
        //Возвращает объект, через который будет осуществляться логирование
        public static ILog Log
        {
            get { return log; }
        }
 
        //Инициализация логера
        public static void InitLogger()
        {
            //Считывание конфигурации логера из файла
            XmlConfigurator.Configure(new System.IO.FileInfo("E:\\TestConf.xml"));
        }
    }
}
