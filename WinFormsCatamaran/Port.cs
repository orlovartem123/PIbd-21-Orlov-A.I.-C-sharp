using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{

    public class Port<T> where T : class, ITransport
    {
        private readonly List<T> _places;

        private readonly int _maxCount;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 240;

        private readonly int _placeSizeHeight = 110;

        private readonly int parkingPlacesInRow;

        public Port(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            parkingPlacesInRow = height;
            _maxCount = width * height;
            _places = new List<T>();
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Port<T> p, T boat)
        {
            if (p._places.Count >= p._maxCount)
            {
                throw new PortOverflowException();
            }
            p._places.Add(boat);
            return true;
        }

        public static T operator -(Port<T> p, int index)
        {
            if (index < -1 || index >= p._places.Count)
            {
                throw new PortNotFoundException(index);
            }
            T boat = p._places[index];
            p._places.RemoveAt(index);
            return boat;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; ++i)
            {
                int x = (i / parkingPlacesInRow) * _placeSizeWidth;
                int y = (i - parkingPlacesInRow * (i / parkingPlacesInRow)) * _placeSizeHeight;
                _places[i].SetPosition(x + 5, y + 5, pictureWidth, pictureHeight);
                _places[i].DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }    }
}


