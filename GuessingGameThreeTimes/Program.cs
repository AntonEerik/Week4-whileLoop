using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud;
            //katsete arv 3;
            //*programm genereerib juhuslikku numbrit ühe korra;
            
            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 3;
            Console.WriteLine($"Arva number 1-10-ni. Sul on {i} katset.");

            while (i>0)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber != cpuNumber)
                {
                    i--;
                    Console.WriteLine($"Vale number! Proovi uuesti! Sul on jäänud {i} katset.");
                }
                else
                {
                    Console.WriteLine("Õige number! Võitsid mängu!");
                    break;
                }
            }
            if (i==0)
            {
                Console.WriteLine("Kaotasid mängu!");
            }
            
            
        }
    }
}