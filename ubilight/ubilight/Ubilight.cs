using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ubilight.LightingSystems;

namespace ubilight
{
    public class Ubilight
    {

        private Dictionary<string, LightSource> _lightSources = new Dictionary<string, LightSource>();
        private List<ILightingSystem> _lightSystems; 


        public Ubilight(List<ILightingSystem> systems)
        {
            _lightSystems = systems;
            UpdateSources();
        }

        private void UpdateSources()
        {
            _lightSystems.ForEach(system =>
            {
                foreach (var e in system.GetSources())
                {
                    _lightSources.Add(system.Name + e.SystemId, e);
                }
            });
        }


        public void Flip(string id)
        {
            var ls = _lightSources[id];

            ls.On = !ls.On;
        }

        public void SetSourceColor(string id, Color c)
        {

            //_lightSources[id].Color

        }

        public void TurnOn(string id)
        {
            _lightSources[id].On = true;
        }

        public void TurnOff(string id)
        {
            _lightSources[id].On = false;
        }

        public string[] GetLightSourceIDs()
        {
            return _lightSources.Keys.ToArray();
        }

        public void SetLvel(string id, double level)
        {
            _lightSources[id].Level = level;
        }

        public double GetLevel(string id)
        {
            return _lightSources[id].Level;
        }

    }
}
