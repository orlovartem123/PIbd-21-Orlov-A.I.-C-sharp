using System;
using System.Collections.Generic;
using System.IO;
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

        private readonly char separator = ':';

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("PortCollection");
                foreach (var level in portStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Port{separator}{level.Key}");
                    ITransport boat = null;
                    for (int i = 0; (boat = level.Value.GetNext(i)) != null; i++)
                    {
                        if (boat != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (boat.GetType().Name == "Boat")
                            {
                                sw.Write($"Boat{separator}");
                            }
                            if (boat.GetType().Name == "Catamaran")
                            {
                                sw.Write($"Catamaran{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(boat);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, System.Text.Encoding.UTF8))
            {
                string line = sr.ReadLine();
                if (line.Contains("PortCollection"))
                {
                    //очищаем записи
                    portStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                Vehicle boat = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Port"))
                    {
                        key = line.Split(separator)[1];
                        portStages.Add(key, new Port<Vehicle>(pictureWidth,
                        pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Boat")
                    {
                        boat = new Boat(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Catamaran")
                    {
                        boat = new Catamaran(line.Split(separator)[1]);
                    }
                    var result = portStages[key] + boat;
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}