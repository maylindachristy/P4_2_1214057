using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214057
{
    internal class Bait2_1214057 : Product_1214057
    {
        protected string tambah2;

        public Bait2_1214057(string lyric1, string lyric2, string tambah2) : base(lyric1, lyric2)
        {
            this.tambah2 = tambah2;
        }

        public string Tambah2
        {
            get { return tambah2; }
            set { tambah2 = value;  }
        }

    }
}
