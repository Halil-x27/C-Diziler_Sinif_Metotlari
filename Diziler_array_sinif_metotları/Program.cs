using System;

namespace Diziler_sinif_metotlari
{
    class Program
    {
        public static void Main(string[] args)
        {
            // sort

            //sırasız sayi dizisi
            int [] sayiDizisi = {13,23,7,4,16,39};

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //sirali sayi dizisi
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear

            // sayi dizisi elemanlarını kullanarak 2.indexten 2 tane elemanı  sıfırlar.

            Array.Clear(sayiDizisi, 2,2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Reverse  tersine çevirme

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }   


            //İndexOf kaçıncı indexte olduğunu bulma
 
            Array.IndexOf(sayiDizisi, 23);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            } 


            // Resize boyutlandırma

            Array.Resize<int>(ref sayiDizisi, 8);  
            sayiDizisi[7] = 99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }      
            
        }
    }
}
