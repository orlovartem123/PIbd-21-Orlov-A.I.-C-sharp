using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinFormsCatamaran
{
    class Catamaran
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;
        private readonly int catamaranWidth = 104;  //60
        private readonly int catamaranHeight = 100;  //100
        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }

        public Color DopColor { private set; get; }

        public bool PassangerSeat { private set; get; }

        public bool Bobs { private set; get; }

        public Catamaran(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool seats, bool bobs)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            PassangerSeat = seats;
            Bobs = bobs;

        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - catamaranWidth)
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
                    if (_startPosY + step < _pictureHeight - catamaranHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        private void DrawFirstBob(Graphics g, Pen pen, Brush brush, bool isPassangersSeats)
        {
            g.DrawRectangle(pen, _startPosX, _startPosY, 16, 80);
            PointF[] polygonLeft = new PointF[3];
            polygonLeft[0].X = _startPosX;
            polygonLeft[0].Y = _startPosY + 80;
            polygonLeft[1].X = _startPosX + 8;
            polygonLeft[1].Y = _startPosY + 100;
            polygonLeft[2].X = _startPosX + 16;
            polygonLeft[2].Y = _startPosY + 80;
            g.FillPolygon(brush, polygonLeft);
            g.FillRectangle(brush, _startPosX, _startPosY, 16, 80);
            Brush dopBrush = new SolidBrush(DopColor);
            if (isPassangersSeats)
            {
                g.DrawRectangle(pen, _startPosX + 2, _startPosY + 20, 12, 20);
                g.FillRectangle(dopBrush, _startPosX + 2, _startPosY + 20, 12, 20);
            }
        }

        private void DrawSecondBob(Graphics g, Pen pen, Brush brush, bool isPassangersSeats)
        {
            g.DrawRectangle(pen, _startPosX + 44, _startPosY, 16, 80);
            g.FillRectangle(brush, _startPosX + 44, _startPosY, 16, 80);
            PointF[] polygonRight = new PointF[3];
            polygonRight[0].X = _startPosX + 44;
            polygonRight[0].Y = _startPosY + 80;
            polygonRight[1].X = _startPosX + 52;
            polygonRight[1].Y = _startPosY + 100;
            polygonRight[2].X = _startPosX + 60;
            polygonRight[2].Y = _startPosY + 80;
            g.FillPolygon(brush, polygonRight);
            Brush dopBrush = new SolidBrush(DopColor);
            if (isPassangersSeats)
            {
                //g.DrawRectangle(pen, _startPosX + 2, _startPosY + 20, 12, 20);
                //g.FillRectangle(dopBrush, _startPosX + 2, _startPosY + 20, 12, 20);
                g.DrawRectangle(pen, _startPosX + 46, _startPosY + 20, 12, 20);
                g.FillRectangle(dopBrush, _startPosX + 46, _startPosY + 20, 12, 20);
            }
        }

        private void DrawThirdBob(Graphics g, Pen pen, Brush brush, bool isPassangersSeats)
        {
            g.DrawRectangle(pen, _startPosX + 88, _startPosY, 16, 80);
            g.FillRectangle(brush, _startPosX + 88, _startPosY, 16, 80);
            PointF[] polygonRight = new PointF[3];
            polygonRight[0].X = _startPosX + 88;
            polygonRight[0].Y = _startPosY + 80;
            polygonRight[1].X = _startPosX + 96;
            polygonRight[1].Y = _startPosY + 100;
            polygonRight[2].X = _startPosX + 104;
            polygonRight[2].Y = _startPosY + 80;
            g.FillPolygon(brush, polygonRight);
            Brush dopBrush = new SolidBrush(DopColor);
            if (isPassangersSeats)
            {
                //g.DrawRectangle(pen, _startPosX + 2, _startPosY + 20, 12, 20);
                //g.FillRectangle(dopBrush, _startPosX + 2, _startPosY + 20, 12, 20);
                //g.DrawRectangle(pen, _startPosX + 46, _startPosY + 20, 12, 20);
                //g.FillRectangle(dopBrush, _startPosX + 46, _startPosY + 20, 12, 20);
                g.DrawRectangle(pen, _startPosX + 90, _startPosY + 20, 12, 20);
                g.FillRectangle(dopBrush, _startPosX + 90, _startPosY + 20, 12, 20);
            }
        }

        private void DrawFirstSeptum(Graphics g, Pen pen, Brush brush)
        {
            g.DrawRectangle(pen, _startPosX + 16, _startPosY + 16, 28, 50);
            g.FillRectangle(brush, _startPosX + 16, _startPosY + 16, 28, 50);
        }

        private void DrawSecondSeptum(Graphics g, Pen pen, Brush brush)
        {
            g.DrawRectangle(pen, _startPosX + 60, _startPosY + 16, 28, 50);
            g.FillRectangle(brush, _startPosX + 60, _startPosY + 16, 28, 50);
        }



        public void DrawTransport(Graphics g)
        {

            Pen pen = new Pen(Color.Black);
            Brush mainBrush = new SolidBrush(MainColor);
            Brush dopBrush = new SolidBrush(DopColor);
            //switch (Bobs)
            //{
            //    case 1:
            //        DrawFirstBob(g, pen, mainBrush, PassangerSeat);
            //        break;
            //    case 2:
            //        DrawFirstBob(g, pen, mainBrush, PassangerSeat);
            //        DrawSecondBob(g, pen, mainBrush, PassangerSeat);
            //        DrawFirstSeptum(g, pen, dopBrush);
            //        break;
            //    case 3:
            //        DrawFirstBob(g, pen, mainBrush, PassangerSeat);
            //        DrawSecondBob(g, pen, mainBrush, PassangerSeat);
            //        DrawThirdBob(g, pen, mainBrush, PassangerSeat);
            //        DrawFirstSeptum(g, pen, dopBrush);
            //        DrawSecondSeptum(g, pen, dopBrush);
            //        break;
            //}
            DrawSecondBob(g, pen, mainBrush, PassangerSeat);
            if (Bobs)
            {
                DrawFirstBob(g, pen, mainBrush, PassangerSeat);
                DrawThirdBob(g, pen, mainBrush, PassangerSeat);
                DrawFirstSeptum(g, pen, dopBrush);
                DrawSecondSeptum(g, pen, dopBrush);
            }


        }

        
    }


    
}
