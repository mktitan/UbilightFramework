﻿using System.Collections.Generic;
using System.Data;
using System.Drawing;
using Q42.HueApi;

namespace ubilight.LightingSystems
{
    public interface ILightingSystem
    {
        string Name { get; set; }

        List<LightSource> GetSources();
        
        void TurnOff(LightSource ls);
        void TurnOn(LightSource ls);

        bool GetOn(LightSource ls);

        void SetLevel(LightSource ls, double level);

        double GetLevel(LightSource ls);

        Color GetColor(LightSource ls);

        void SetColor(LightSource ls, Color c);

    }
}