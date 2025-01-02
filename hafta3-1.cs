using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace hafta3
{
    internal class Program
    {




        static void Main(string[] args)
        {
          
            ArrayList sayilar = new ArrayList { 190, 5, 33, 689, 15 };

            
            int toplam = 0;

            
            Console.WriteLine("Liste Elemanları:");
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
                toplam += sayi; 
            }

          
            Console.WriteLine($"Sayıların Toplamı: {toplam}");
            Console.ReadKey();
        }


    }
    
}

