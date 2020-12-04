using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCatamaran
{
    class PortNotFoundException : Exception
    {
        public PortNotFoundException(int i) : base("Не найден транспорт по месту " + i) { }
    }
}
