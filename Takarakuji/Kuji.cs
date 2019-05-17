using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takarakuji
{
    class Kuji
    {
        public int Number { get; }
        public String Kekka { get; set; }

        public Kuji(int number)
        {
            Number = number;
            Kekka = "";
        }
    }
}
