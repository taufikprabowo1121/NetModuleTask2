using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10] {11,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("Hasil Perbandingan :");
           
            int kecil = array[0];
            for (int i = 0; i < 10; i++)

            {
                if (array[i] < kecil)
                {
                    kecil = array[i];

                }
            }
            int besar = array[9];
            for (int i = 0; i < 10; i++)
            {

                if (array[i] > besar)
                {
                    besar = array[i];

                }
            }
            Console.WriteLine("Angka Terkecil Adalah {0}", kecil);
            Console.WriteLine("Angka Terbesar Adalah {0}", besar);
            Console.Read();
        }
    }
}
