using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var locations = new Hashtable();
            locations.Add("Home", new Point(49.2, -123.4));
            locations.Add("Store A", new Point(49.3, -123.4));
            locations.Add("Store B", new Point(49.3, -123.3));
            locations.Add("Intersection", new Point(49.2, -123.2));

            var roads = new List<Road>();
            roads.Add(new Road("Home", "Store A"));
            roads.Add(new Road("Home", "Store B"));
            roads.Add(new Road("Home", "Intersection"));
            roads.Add(new Road("Store A", "Home"));
            roads.Add(new Road("Store A", "Store B"));
            roads.Add(new Road("Intersection", "School"));
            roads.Add(new Road("Store B", "School"));
            roads.Add(new Road("School", "Store B"));
            roads.Add(new Road("School", "Intersection"));

            var home = locations["Home"];
            var school = locations["School"];
            var fastestPathFromHomeToSchool = new List<Road>();

            var hashTable = new Hashtable();

            bool foundSchool;
            while (!foundSchool)
            {
                foreach (var road in roads)
                {
                    if(road.Start == "Home")
                }
            }

            for(var i=0; i < roads.Count; i++)
            {
                var key = $"{road.Start}{road.End}";
                var startPt = (Point)locations[$"{road.Start}"];
                var endPt = (Point)locations[$"{road.End}"];
                var distance = startPt.CalculateDistance(endPt);
                
                hashTable.Add(key, distance);
                midLocations.Add(road.End);
            }

            foreach (var key in hashTable.Keys)
            {
                Console.WriteLine($"{key}: {hashTable[key]}");
            }

            // Find quickest path from Home to School
        }
    }
}