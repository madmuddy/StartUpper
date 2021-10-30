using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using System.Windows.Forms;

namespace StartUpper
{
    static class Core
    {
        public static int AddStartUp()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                for (int i = 0; i < Consts.Apps.Count; i++)
                {
                    rk.SetValue(Consts.Apps[i], Consts.AppsLoc[i]);
                }

                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public static int RemoveStartUp()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

                for (int i = 0; i < Consts.Apps.Count; i++)
                {
                    rk.DeleteValue(Consts.R_Apps[i], false);
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
