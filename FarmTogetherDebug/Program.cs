using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmTogetherToolsLib;

namespace FarmTogetherDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Config cfg = new Config();
            cfg.Rendersize = 0.01f;
            
            cfg.Save("D:\\global_config.xml");

            

            Console.ReadKey();
        }
    }
}
