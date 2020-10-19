using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{

    public class Parking<T> where T : class, ITransport
    {

        private readonly T[] _places;

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly int _placeSizeWidth = 240;

        private readonly int _placeSizeHeight = 110;

        private readonly int parkingPlacesInRow;

        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            parkingPlacesInRow = height;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }

        public static bool operator +(Parking<T> p, T boat)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = boat;
                    int x = (i / p.parkingPlacesInRow) * p._placeSizeWidth;
                    int y = (i - p.parkingPlacesInRow * (i / p.parkingPlacesInRow)) * p._placeSizeHeight;
                    boat.SetPosition(x+5, y+5);
                    return true;
                }
            }
            return false;
        }

        public static T operator -(Parking<T> p, int index)
        {
            if (index >= p._places.Length || index < 0)
            {
                return null;
            }
            T boat = p._places[index];
            p._places[index] = null;
            return boat;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
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
    }
}


