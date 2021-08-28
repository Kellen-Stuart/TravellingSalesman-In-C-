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
            Data.InitializeData();
            Console.WriteLine($"Find Random Path Algorithm");
            var path = Algorithms.FindRandomPath();
            Console.WriteLine(path.ToString());
        }
    }
}