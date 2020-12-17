using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{
    class PortAlreadyHaveException : Exception
    {
        public PortAlreadyHaveException() : base("На парковке уже есть такой транспорт") { }
    }
}
