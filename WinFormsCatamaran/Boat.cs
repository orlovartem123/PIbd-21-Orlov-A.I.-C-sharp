using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{
    public class Boat : Vehicle
    {
        protected readonly int boatWidth = 104;

        protected readonly int boatHeight = 100;

        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        protected Boat(int maxSpeed, float weight, Color mainColor, int boatWidth, int
       boatHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.boatWidth = boatWidth;
            this.boatHeight = boatHeight;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainBrush = new SolidBrush(MainColor);
            g.DrawRectangle(pen, _startPosX + 44, _startPosY, 16, 80);
            g.FillRectangle(mainBrush, _startPosX + 44, _startPosY, 16, 80);
            PointF[] polygonRight = new PointF[3];
            polygonRight[0].X = _startPosX + 44;
            polygonRight[0].Y = _startPosY + 80;
            polygonRight[1].X = _startPosX + 52;
            polygonRight[1].Y = _startPosY + 100;
            polygonRight[2].X = _startPosX + 60;
            polygonRight[2].Y = _startPosY + 80;
            g.FillPolygon(mainBrush, polygonRight);
        }
    }
}
