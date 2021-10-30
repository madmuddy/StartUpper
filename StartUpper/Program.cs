using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartUp.Configure();
                Reader.LoadData();

                Core.AddStartUp();
                Core.RemoveStartUp();
            }
            catch
            {
            }
        }
    }
}
