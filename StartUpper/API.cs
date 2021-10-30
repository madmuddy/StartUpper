using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpper
{
    public static class API
    {
        public static int AddStartUps()
        {
            try
            {
                StartUp.Configure();
                Reader.LoadData();

                Core.RemoveStartUp();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int AddStartUps(List<string> _Apps)
        {
            try
            {
                Consts.Apps = _Apps;
                Core.RemoveStartUp();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int AddStartUps(Config conf)
        {
            try
            {
                Consts.programPath = conf.programPath;
                Consts.tempPath = conf.tempPath;
                Consts.appFileName = conf.appFileName;
                Consts.appLocationFileName = conf.appLocationFileName;
                Consts.appLocationFilePath = conf.appLocationFilePath;
                Consts.appFilePath = conf.appFilePath;
                Consts.R_appFileName = conf.R_appFileName;
                Consts.R_appFilePath = conf.R_appFilePath;
                Consts.Apps = conf.Apps;
                Consts.R_Apps = conf.R_Apps;

                Reader.LoadData();

                Core.RemoveStartUp();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int RemovesStartUps()
        {
            try
            {
                StartUp.Configure();
                Reader.LoadData();

                Core.RemoveStartUp();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int RemovesStartUps(List<string> _R_Apps)
        {
            try
            {
                Consts.R_Apps = _R_Apps;
                Core.RemoveStartUp();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int RemovesStartUps(Config conf)
        {
            try
            {
                Consts.programPath = conf.programPath;
                Consts.tempPath = conf.tempPath;
                Consts.appFileName = conf.appFileName;
                Consts.appLocationFileName = conf.appLocationFileName;
                Consts.appLocationFilePath = conf.appLocationFilePath;
                Consts.appFilePath = conf.appFilePath;
                Consts.R_appFileName = conf.R_appFileName;
                Consts.R_appFilePath = conf.R_appFilePath;
                Consts.Apps = conf.Apps;
                Consts.R_Apps = conf.R_Apps;

                Reader.LoadData();

                Core.RemoveStartUp();

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public struct Config
        {
            public string programPath;
            public string tempPath;

            public string appFileName;
            public string appFilePath;

            public string appLocationFileName;
            public string appLocationFilePath;

            public string R_appFileName;
            public string R_appFilePath;

            public List<string> Apps;
            public List<string> AppsLoc;
            public List<string> R_Apps;
       }
    }
}
