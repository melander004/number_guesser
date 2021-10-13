using System;

namespace number_guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random nmr = new Random();
            int tal = nmr.Next(1, 101);
            Console.Write("Gissa ett heltal mellan 1 och 100: ");
            int försök = 0;
            while (true)
            {
                int svar = int.Parse(Console.ReadLine());
            
                if (svar < tal){
                    Console.WriteLine("Du gissade för lågt, gissa igen!");
                    försök++;
                }
                
                else if (svar > tal){
                    Console.WriteLine("Du gissade för högt, gissa igen!");
                    försök++;
                }

                else if (svar == tal){
                    försök++;
                    Console.WriteLine($"Du gissade rätt efter {försök} försök!");
                    break;
                } 
            }
        }
    }
}
