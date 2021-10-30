using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StartUpper
{
    static class Reader
    {
        public static int LoadData()
        {
            try
            {
                if(!File.Exists(Consts.appFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(Consts.appFilePath))
                    {
                        sw.Close();
                    }
                }
                else
                {
                    Consts.Apps = File.ReadAllLines(Consts.appFilePath).ToList();
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
