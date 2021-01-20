using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donustur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ekrana bir yazı giriniz");
            string lettering = Console.ReadLine();
            Console.WriteLine("Yazdığınız yazı " + lettering);
            int number = lettering.Length;
            Console.WriteLine("Yazdığınız yazının harf sayısı " + number);
            string uppercase = lettering.ToUpper();
            Console.WriteLine("Yazdığınız yazının büyük harfli yazımı " + uppercase);

            string intentiation = "";
            for (int i = 0; i < lettering.Length; i++)
            {
               intentiation+= (lettering[i]).ToString() .ToUpper() + ".";

                
              
            }

            Console.WriteLine("Yazdığınız yazının boşluklu yazımı " + intentiation);
            
            



            Console.ReadLine();
        }
    }
}
