using System;

namespace Lexicon_vecka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choise;

            do
            {
                Console.WriteLine("Gör ditt val");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraktion");
                Console.WriteLine("3) Multiplikation");
                Console.WriteLine("4) Division");
                Console.WriteLine("0) Avsluta");

                try
                {
                    choise = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Försök hålla dig till siffror");
                    choise = 5;
                }
                switch (choise){
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;

                }
            } while (choise!=0);
        }

        public struct Numbers
        {
            public int number1;            
            public int number2;
        }

        public static Numbers ReadNumbers(string instructions)
        {
            string[] array = Console.ReadLine().Split(' ');
            Numbers numbers = new Numbers();
            numbers.number1 = int.Parse(array[0]);
            numbers.number2 = int.Parse(array[1]);
            return numbers;
        }

        public static void Add()
        {
            Numbers numbers = ReadNumbers("Du valde addition. Skriv in två tal som du vill addera. Talen skall skrivas med mellanslag emellan dem.");
            Console.WriteLine("Summan av talen är: " + (numbers.number1 + numbers.number2));
        }

        public static void Subtract()
        {
            Numbers numbers = ReadNumbers("Du valde subtraction. Skriv in två tal som du vill subtrahera. Talen skall skrivas med mellanslag emellan dem.");
            Console.WriteLine("Differnsen av talen är: " + (numbers.number1 - numbers.number2));
        }

        public static void Multiply()
        {
            Numbers numbers = ReadNumbers("Du valde multiplikation. Skriv in två tal som du vill multiplicera. Talen skall skrivas med mellanslag emellan dem.");
            Console.WriteLine("Produkten av talen är: " + (numbers.number1 * numbers.number2));
        }

        public static void Divide()
        {
            Numbers numbers = ReadNumbers("Du valde division. Skriv in två tal som du vill dividera. Talen skall skrivas med mellanslag emellan dem.");
            if (numbers.number2 == 0)
            {
                Console.WriteLine("Division med 0 är ej tilåtet på kurser köpta av arbetsförmedlingen.");
            }
            else
            {
                Console.WriteLine("Kvoten av talen är: " + (numbers.number1 / numbers.number2) + " Resten är: " + (numbers.number1 % numbers.number2));
            }
        }
    }
}
