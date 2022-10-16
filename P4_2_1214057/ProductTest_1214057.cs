using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214057
{
    internal class ProductTest_1214057
    {
        static void main(string[] args)
        {
            Bait1_1214057 product1 = new Bait1_1214057("we got", "lost in", "translation");
            Bait2_1214057 product2 = new Bait2_1214057("i asked", "for", "too much");
            Bait3_1214057 product3 = new Bait3_1214057("this thing was a masterpiece", "`till you", "tore it all up");

            Console.WriteLine("And maybe {0} {1} {2}", product1.MyLyric1, product1.MyLyric2, product1.Tambah1);
            Console.WriteLine("Maybe {0} {1} {2}", product2.MyLyric1, product2.MyLyric2, product2.Tambah2);
            Console.WriteLine("But maybe {0} {1} {2}", product3.MyLyric1, product3.MyLyric2, product3.Tambah3);
            Console.WriteLine("Running scared, i was there, i remeber it all to welll");
        }
    }
}
