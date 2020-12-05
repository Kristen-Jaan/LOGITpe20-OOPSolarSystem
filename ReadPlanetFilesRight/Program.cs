using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ReadPlanetFilesRight
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
            ReadPlanetFiles();
        }

        public static void ReadPlanetFiles()
        {
            string filePath = @"C:\Users\opilane\Samples";
            string fileName = @"planets.txt";

            List<Planets> planets = new List<Planets>();

            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach(string line in linesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Planets newPlanets = new Planets(tempArray[0], Int32.Parse(tempArray[1]));
                planets.Add(newPlanets);
            }

            int total = 0;

            foreach(Planets planet in planets)
            {
                Console.WriteLine($"Planet: {planet.Name}; Mass: {planet.Mass}");
                total += planet.Mass;
            }
            Console.WriteLine($"Total mass: {total}");


        }

       

        
    }
}
