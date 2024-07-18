using System;

namespace whileExam
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.  

            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Kendime inanıyorum,ben bu yazılım işini hallederim!");
                count++;
            }
            Console.WriteLine("------------------------------------------------");
            //1-20 arasındaki sayıları yazdır
            int spacednumber = 1;

            while(spacednumber < 20)
            {
                Console.WriteLine(spacednumber);
                spacednumber++;
            }
            Console.WriteLine("------------------------------------------------");
            //1-20 arasındaki çift sayılar
            int evennumber = 0;
            while (evennumber < 20) 
            { 
                if (evennumber % 2 == 0)
                {
                    Console.WriteLine(evennumber);
                }
                evennumber++;
            }
            Console.WriteLine("------------------------------------------------");
            //50-150 arasındaki sayıların toplamını yaz
            int k = 50;
            int total = 0;

            while ( k < 150)
            {
                total += k;
                k++;
            }
            Console.WriteLine($"Toplam sayı değeri {total}");

            Console.WriteLine("------------------------------------------------");
            //1-120 arasındaki tek ve çift sayıları yazdırma
            int oddNumber = 0;
            int evenNumber = 0;
            int t = 1;

            while(t < 120) 
            {
                if(t % 2 == 0)
                {
                    evenNumber += t;
                    
                }else
                {
                    oddNumber += t;
                    
                }
                t++;
            }
            Console.WriteLine($"Çift Sayıların Toplamı {evenNumber}");
            Console.WriteLine($"Tek Sayıların Toplamı {oddNumber}");
        }
    }
}