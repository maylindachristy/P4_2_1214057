using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214057
{
    internal class Bait3_1214057 : Product_1214057
    {
        protected string tambah3;

        public Bait3_1214057(string lyric1, string lyric2, string tambah3) : base (lyric1, lyric2)
        {
            this.tambah3 = tambah3;
        }

        public string Tambah3
        {
            get { return tambah3; }
            set { tambah3 = value; }
        }
    }
}
