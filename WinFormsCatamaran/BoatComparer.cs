using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{
    public class BoatComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Catamaran && y is Catamaran)
            {
                return ComparerCatamaran((Catamaran)x, (Catamaran)y);
            }
            if (x is Catamaran && y is Boat)
            {
                return 1;
            }
            if (x is Boat && y is Catamaran)
            {
                return -1;
            }
            if (x is Boat && y is Boat)
            {
                return ComparerBoat((Boat)x, (Boat)y);
            }
            return 0;
        }

        public int ComparerBoat(Boat x, Boat y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerCatamaran(Catamaran x, Catamaran y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.PassangerSeat != y.PassangerSeat)
            {
                return x.PassangerSeat.CompareTo(y.PassangerSeat);
            }
            if (x.Bobs != y.Bobs)
            {
                return x.Bobs.CompareTo(y.Bobs);
            }
            return 0;
        }
    }
}
