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
                Consts.appFilePath = Path.Combine(Consts.tempPath, Consts.appFileName);
                Consts.appLocationFilePath = Path.Combine(Consts.tempPath, Consts.appLocationFileName);
                Consts.R_appFilePath = Path.Combine(Consts.tempPath, Consts.R_appFileName);

                return 1;
            }
            catch
            {
                return 0;
            }
        }   
    }
}
