using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorDemo;
using Q42.HueApi;
using Q42.HueApi.Interfaces;
using Q42.HueApi.Models.Groups;
using ubilight.LightingSystems;

namespace ubilight
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
            HueClient client = new HueClient("localhost:8000");
            client.RegisterAsync("ubilight", "ubilightkey");
            client.Initialize("ubilightkey");

            var command = new LightCommand();

            var colorhex = Helpers.ColorToHex(Color.Blue);

            Console.WriteLine(colorhex);

            

            //var c = Helpers.FromHSL(lState.Hue.GetValueOrDefault(), lState.Saturation.GetValueOrDefault(), lState.Brightness);

            

            client.SendCommandAsync(command, new List<string>{"1"});
            */

            var ubi = new Ubilight(new List<ILightingSystem>{new HueLightingSystem("hue")});

            var ids = ubi.GetLightSourceIDs();

            foreach (var id in ids)
            {
                Console.WriteLine(id);
            }

            //TODO Currently acts on all bulbs, as if they're in a group
            Console.WriteLine("flipping id: " + ids[1]);
            //ubi.Flip(ids[1]);

            ubi.SetLvel(ids[1], 1);
            Console.WriteLine(ubi.GetLevel(ids[1]));
            

            Console.Read();

        }
    }
}
