using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaratYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ** Karar Yapilari ** *
             *   ==
             *   >
             *   < 
             *   !=
             *   >=
             *   <=
             * 
             * */

            /*int a = 5;
            int b = 6;
            int sonuc = 0;

            sonuc = a > b ? a : b;*/
            //Çok uzun satırlı kodlarda if yerine soru işareti kullanılarak kod satırı sayısını azaltabiliriz.
            
            /*
             * Kullanıcıdan int değer alabilmek için alınan stringi inte dönüştürmek için gerekiyor
             * Int32.Parse(Console.ReadLine());
            */


            //Girilen sayinin 5 in kati olup olmadığını kontrol eden program.

            Console.WriteLine("Bir sayi giriniz.");
            int sayi = Int32.Parse(Console.ReadLine());

            /*
            if((sayi%5)==0)
                Console.WriteLine("Sayi 5 in kati");
            else
                Console.WriteLine("Sayi 5 in kati değil");
            */

            //Aynı kodu switch-case ile yapmak istersem
            /*switch(sayi % 5)
            {
                case 0:
                    Console.WriteLine("5 in katı");
                    break;
                default:
                    Console.WriteLine("5 in katı değil");
                    break;
            }*/

            // foreach döngüsü dizideki tüm elemanları gezerek ekrana vermemi sağlıyor.
            // Amacı bir dizi elemanın tüm elemanlarına aynı anda erişim yapmak.

            /* string[] isimler = {"Ali", "Serdar", "Melis", "Fuat" };
             foreach(var isim in isimler)
             {
                 Console.WriteLine(isim);
             }
             */

            // ****  DİZİLER  ****
            /*int[] sayilar = new int[5];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;
            sayilar[4] = 5;

            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }*/

            //Sürekli değişiklik gerektiren durumlarda diziler yerine Collectionlar kullanılmalıdır
            List<string> list = new List<string>();
            list.Add("Funda");
            list.Add("Ali");
            list.Add("Serdar");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            

        }
    }
}
