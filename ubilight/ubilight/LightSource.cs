using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q42.HueApi;
using ubilight.LightingSystems;

namespace ubilight
{
    public class LightSource
    {   


        public string SystemId { get; private set; }

        public LightSource(ILightingSystem ls, string systemId)
        {
            LightingSystem = ls;
            SystemId = systemId;
        }

        public bool On {
            get { return LightingSystem.GetOn(this); }
            set
            {
                if (value)
                {
                    LightingSystem.TurnOn(this);
                }
                else
                {
                    LightingSystem.TurnOff(this);
                }
            }
        }

        public Color Color
        {
            get { return LightingSystem.GetColor(this); }
            set
            {
                LightingSystem.SetColor(this, value);
            }
        }

        public double Level
        {
            get { return LightingSystem.GetLevel(this); }
            set{ LightingSystem.SetLevel(this, value); }
        }


        public ILightingSystem LightingSystem { get; private set; }
    }
}
