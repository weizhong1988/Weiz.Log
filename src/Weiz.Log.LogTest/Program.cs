using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weiz.Log.LogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                try
                {
                    Logs.Instance.Info("测试测试");
                    if (i % 1000 == 0)
                    {
                        int x = 0;
                        x = 1 / x;
                    }
                }
                catch (Exception ex)
                {
                    Logs.Instance.Error(ex.Message + ex.StackTrace);
                }
            }

            Console.ReadKey();
        }

    }
}
