using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StartUpper
{
    static class StartUp
    {
        public static int Configure()
        {
            try
            {
                Consts.programPath = Directory.GetCurrentDirectory();
                Consts.tempPath = Path.GetTempPath();
                Consts.startUpPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                Consts.appFilePath = Path.Combine(Consts.tempPath, Consts.appFileName);

                return 1;
            }
            catch
            {
                return 0;
            }
        }   
    }
}
