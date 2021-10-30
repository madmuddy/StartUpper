using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpper
{
    public static class API
    {
        public struct Config
        {
            public string programPath;
            public string tempPat;
            public static string startUpPath;

            public string appFileName;
            public string appFilePath;

            public List<string> Apps;
        }
    }
}
