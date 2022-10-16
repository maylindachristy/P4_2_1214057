using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214057
{
    internal class Bait1_1214057 : Product_1214057
    {
        protected string tambah1;

        public Bait1_1214057(string lyric1, string lyric2,  string tambah1) : base(lyric1, lyric2)
        {
            this.tambah1 = tambah1;
            
        }

        public string Tambah1
        {
            get { return tambah1; }
            set { tambah1 = value; }
        }
    }
}
