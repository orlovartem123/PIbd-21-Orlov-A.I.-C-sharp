using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{
    class PortCollection
    {
        readonly Dictionary<string, Port<Vehicle>> portStages;

        public List<string> Keys => portStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public PortCollection(int pictureWidth, int pictureHeight)
        {
            portStages = new Dictionary<string, Port<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (portStages.ContainsKey(name))
            {
                return;
            }
            portStages.Add(name, new Port<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (portStages.ContainsKey(name))
            {
                portStages.Remove(name);
            }
        }

        public Port<Vehicle> this[string ind]
        {
            get
            {
                if (portStages.ContainsKey(ind))
                {
                    return portStages[ind];
                }
                return null;
            }
        }

        public Port<Vehicle> this[int num]
        {
            get
            {
                if (num > -1 && num < Keys.Count)
                {
                    return portStages[Keys[num]];
                }
                return null;
            }
        }
    }
}
