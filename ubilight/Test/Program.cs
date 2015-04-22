using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ubilight;
using ubilight.LightingSystems;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var ubi = new Ubilight(new List<ILightingSystem>(){new HueLightingSystem("hue")});

            foreach (var s in ubi.GetLightSourceIDs())
            {
                Console.WriteLine(s);
            }


            ubi.Flip("hue1");


            Console.Read();
        }
    }
}
