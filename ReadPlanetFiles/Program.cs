using System;
using System.Collections.Generic;
using System.IO;

namespace ReadPlanetFiles
{
    class Program
    {
        public class Planets
        {
            string name;
            int mass;

            public Planets(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Help Me!");
            WritePlanetList();
        }

        public static void WritePlanetList()
        {
            List<string> planetList = new List<string>();
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine("Enter a planet: ");
                string planet = Console.ReadLine();
                Console.WriteLine("What's the mass?");
                string mass = Console.ReadLine();

                string line = $"{planet}/{mass}";
                planetList.Add(line);
            }

            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"planets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), planetList);
        }
    }
}
