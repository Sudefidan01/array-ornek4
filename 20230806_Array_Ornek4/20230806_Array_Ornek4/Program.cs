using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Array_Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ornek 4
            //Eleman sayısının kullanıcının belirlediği bir dizi oluşturalım
            //Sonra bu dizinin içini isimlerle dolduralım

            int adet;
            Console.Write("Kaç Kişi Gireceksiniz : ");
            adet = int.Parse(Console.ReadLine());

            string[] kisiler = new string[adet];

            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.Write((i + 1) + ".Kişinin Adını Giriniz :");
                kisiler[i] = Console.ReadLine();
            }
            Console.WriteLine();

            foreach (var item in kisiler)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
