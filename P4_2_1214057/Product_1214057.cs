using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214057
{
    public class Product_1214057
    {
        private  string myLyric1;
        private string myLyric2;

        public Product_1214057()
        {

        }

        public Product_1214057(string lyric1, string lyric2)
        {
            this.myLyric1 = lyric1;
            this.myLyric2 = lyric2;
        }

        public string MyLyric1
        {
            get
            {
                return myLyric1;
            }
            set
            {
                myLyric1 = value;
            }
        }

        public string MyLyric2
        {
            get
            {
                return myLyric2;
            }
            set
            {
                myLyric2 = value;
            }
        }
    }
}
