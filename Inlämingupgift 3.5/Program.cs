using System;
namespace inlämningsuppgift3_5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj ett heltal:");
            int heltal1= int.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett till heltal:");
            int heltal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Välj mellan 1. addition 2. subtraktion 3. multiplikation 4. division");
            String x = Console.ReadLine();
            switch (x) 
            {

                case "1":
                    Console.WriteLine(heltal1 + heltal2);
                    break;
                case "2":
                    Console.WriteLine(heltal1 - heltal2);
                    break;

                case "3":
                    Console.WriteLine(heltal1 * heltal2);
                    break;

                case "4":
                    Console.WriteLine(heltal1 / heltal2);
                    break;



            }

        }
    }
}

