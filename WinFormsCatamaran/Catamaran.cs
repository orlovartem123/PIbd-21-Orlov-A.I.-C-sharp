using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsCatamaran
{
    class Catamaran : Boat
    {
        public Color DopColor { private set; get; }

        public bool PassangerSeat { private set; get; }

        public bool Bobs { private set; get; }

        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool seats, bool bobs) : base(maxSpeed, weight, mainColor, 104, 100)
        {
            DopColor = dopColor;
            PassangerSeat = seats;
            Bobs = bobs;
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush mainBrush = new SolidBrush(MainColor);
            Brush dopBrush = new SolidBrush(DopColor);
            base.DrawTransport(g);
            if (Bobs)
            {
                g.DrawRectangle(pen, _startPosX, _startPosY, 16, 80);
                PointF[] polygonLeft = new PointF[3];
                polygonLeft[0].X = _startPosX;
                polygonLeft[0].Y = _startPosY + 80;
                polygonLeft[1].X = _startPosX + 8;
                polygonLeft[1].Y = _startPosY + 100;
                polygonLeft[2].X = _startPosX + 16;
                polygonLeft[2].Y = _startPosY + 80;
                g.FillPolygon(mainBrush, polygonLeft);
                g.FillRectangle(mainBrush, _startPosX, _startPosY, 16, 80);
                g.DrawRectangle(pen, _startPosX + 88, _startPosY, 16, 80);
                g.FillRectangle(mainBrush, _startPosX + 88, _startPosY, 16, 80);
                PointF[] polygonRight = new PointF[3];
                polygonRight[0].X = _startPosX + 88;
                polygonRight[0].Y = _startPosY + 80;
                polygonRight[1].X = _startPosX + 96;
                polygonRight[1].Y = _startPosY + 100;
                polygonRight[2].X = _startPosX + 104;
                polygonRight[2].Y = _startPosY + 80;
                g.FillPolygon(mainBrush, polygonRight);
                g.DrawRectangle(pen, _startPosX + 16, _startPosY + 16, 28, 50);
                g.FillRectangle(mainBrush, _startPosX + 16, _startPosY + 16, 28, 50);
                g.DrawRectangle(pen, _startPosX + 60, _startPosY + 16, 28, 50);
                g.FillRectangle(mainBrush, _startPosX + 60, _startPosY + 16, 28, 50);
            }
            if (PassangerSeat)
            {
                if (Bobs)
                {
                    g.DrawRectangle(pen, _startPosX + 2, _startPosY + 20, 12, 20);
                    g.FillRectangle(dopBrush, _startPosX + 2, _startPosY + 20, 12, 20);
                    g.DrawRectangle(pen, _startPosX + 90, _startPosY + 20, 12, 20);
                    g.FillRectangle(dopBrush, _startPosX + 90, _startPosY + 20, 12, 20);
                    g.DrawRectangle(pen, _startPosX + 46, _startPosY + 20, 12, 20);
                    g.FillRectangle(dopBrush, _startPosX + 46, _startPosY + 20, 12, 20);
                }
                else
                {
                    g.DrawRectangle(pen, _startPosX + 46, _startPosY + 20, 12, 20);
                    g.FillRectangle(dopBrush, _startPosX + 46, _startPosY + 20, 12, 20);
                }
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
