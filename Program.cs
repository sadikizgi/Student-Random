using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB01032017
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] notlar = new int[20, 3]; // 20 tane 3 boyutlu dizi oluşturmuş olduk
            for (int i = 0; i < notlar.GetLength(0); i++)
            {
                for (int r = 0; r < notlar.GetLength(1); r++)  // bu getlength aynı length gibi. 
                {
                    notlar[i, r] = rnd.Next(0, 101);


                }

            }

            int[] histogram = new int[10];

            for (int i = 0; i < notlar.GetLength(0); i++)
            {
                Console.Write((i + 1) + "öğrenci");
                double ortalama = 0;
                for (int r = 0; r < notlar.GetLength(1); r++)  // bu getlength aynı length gibi. 
                {
                    Console.Write("\t" + notlar[i, r]);
                    ortalama += notlar[i, r];

                }
                ortalama = ortalama / notlar.GetLength(1);
                if (ortalama == 100)
                {
                    histogram[9]++;
                }

                else

                    histogram[(int)ortalama / 10]++;
                Console.WriteLine("\t" + ortalama);
            }

            for (int i = 0; i < histogram.Length; i++)
            {
                Console.Write(i*10 + "-" +(i*10 + 9 ));
                for (int m = 0; m < histogram[i]; m++)
                {
                    Console.Write(" *");

                }
                Console.WriteLine();
            }
           
            }
        }
    }
        
    

