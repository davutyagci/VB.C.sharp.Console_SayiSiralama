using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayı_Sıralama
{
    enum SiralamaTipi
    {
        Artan = 1,
        Azalan = 2
    }
   
    class Program
    {
        public static int[] Sirala(int[] dizisirala, SiralamaTipi tip)
        {
            if (tip == SiralamaTipi.Azalan)
            {
                for (int i = 0; i < dizisirala.Length; i++)
                {
                    for (int k = i + 1; k < dizisirala.Length; k++)
                    {
                        if (dizisirala[i] < dizisirala[k])
                        {
                            int temp = dizisirala[i];
                            dizisirala[i] = dizisirala[k];
                            dizisirala[k] = temp;
                        }
                    }
                }
            }

            else if (tip == SiralamaTipi.Artan)
            {
                for (int i = 0; i < dizisirala.Length; i++)
                {
                    for (int k = i + 1; k < dizisirala.Length; k++)
                    {
                        if (dizisirala[i] > dizisirala[k])
                        {
                            int temp = dizisirala[i];
                            dizisirala[i] = dizisirala[k];
                            dizisirala[k] = temp;
                        }
                    }
                }
            }
            return dizisirala;
        }

       static void Main(string[] args)
        {
            tekrar:
           
            Console.WriteLine("\nKüçükten Büyüğe: 1\t Büyükten Küçüğe: 2");
            Console.Write("\nSıralama Tipi: ");
            SiralamaTipi tip = (SiralamaTipi)Convert.ToInt32(Console.ReadLine());

            if (tip != SiralamaTipi.Artan && tip != SiralamaTipi.Azalan)
            {
                Console.WriteLine("\n\n\tYANLIŞ TİP SEÇİMİ!");
                goto tekrar;
            }

            Console.Write("\n\nKaç Adet Sayı: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("\n{0}. Sayı: ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] SiralanmisSonuc = Sirala(sayilar, tip);
            Console.Write("\nSonuç: ");
            foreach (int item in SiralanmisSonuc)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Devam Etmek İstiyor musunuz? (e/h): ");
            string cvp = Console.ReadLine();
            if (cvp == "e")
            {
                Console.WriteLine("");
                goto tekrar;
            }
            else
            {
                Console.Clear();
            }
            
        }
    }
}
