using System;
using System.Linq;
using DataProblem1.Algorithm;

namespace DataProblem1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Data.InitializeData();
            var start = Data.Places.Single(x => x.Name == "Home");
            var end = Data.Places.Single(x => x.Name == "Pusher BMX");
            var algorithm = new AllPathsChooseShortest();

            var path = algorithm.FindPath(start, end);
            Console.WriteLine(path);
        }
    }
}