using System.Runtime.InteropServices;

namespace ChatGPTLagdeOppger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn navnet ditt");
            string name = Console.ReadLine();

            Console.WriteLine("Legg inn bok");
            string bok = Console.ReadLine();

            var biblotek = new List<string> { bok, "Harry Potter", "Ringnes Herre", "Narnia" };

            while (true)
            {
                Console.WriteLine($"Hei {name}, Her er bibloteket ditt");
                for (int i = 0; i < biblotek.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {biblotek[i]}");
                }

                Console.WriteLine("\nVelg en handling:");
                Console.WriteLine("1: Låne ut bok");
                Console.WriteLine("2: kreve inn bok");
                Console.WriteLine("3: Avslutt");

                string valg = Console.ReadLine();
                switch (valg)
                {
                    case "1":
                        Console.WriteLine("\nSkriv inn navn på boken du vil låne");
                        string bokUt = Console.ReadLine();
                        if (biblotek.Contains(bokUt))
                        {
                            Console.WriteLine($"Du har lånt ut {bokUt}");
                            biblotek.Remove(bokUt);
                        }
                        else
                        {
                            Console.WriteLine("Boken finnes ikke i biblioteket.");
                        }

                        break;

                    case "2":
                        Console.WriteLine("\nSkriv inn navn på bok du vil kreve inn.");
                        string bokInn = Console.ReadLine();
                    {
                        biblotek.Add(bokInn);
                        Console.WriteLine($"Boken '{bokInn}' er lagt til i bibloteket.");
                        }

                        break;

                    case "3":
                        Console.WriteLine("Avslutter programmet.");
                        break;
                }


            }
        }
    }
}

