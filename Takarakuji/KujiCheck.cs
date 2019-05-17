using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takarakuji
{
    class KujiCheck
    {
        private int rank1;
        private int rank2;
        private int rank3;
        
        public int Total { get; private set; }

        public KujiCheck(int rank1, int rank2, int rank3)
        {
            this.rank1 = rank1;
            this.rank2 = rank2;
            this.rank3 = rank3;
            this.Total = 0;
        }

        public int check(Kuji kuji)
        {
            int kingaku = 0;
            if( kuji.Number == rank1)
            {
                kuji.Kekka = "1等";
                kingaku = 10000;
            }else
            if (kuji.Number % 10000 == rank2)
            {
                kingaku = 1000;
                kuji.Kekka = "2等";
            }
            else
            if (kuji.Number % 100 == rank3)
            {
                kingaku = 100;
                kuji.Kekka = "3等";
            }
            else
            {
                kuji.Kekka = "外れ";
            }
            this.Total += kingaku;
            return kingaku;
        }

        public void reset()
        {
            this.Total = 0;
        }
    }
}
