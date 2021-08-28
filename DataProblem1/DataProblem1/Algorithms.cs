using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace DataProblem1
{
    public static class Algorithms
    {
        public static Path ShortestPathAlgorithm()
        {

            var start = Data.Places.Single(x => x.Name == "Home");
            var end = Data.Places.Single(x => x.Name == "School");

            var path = new Path();
            path.AddPlace(start);
            while (path.Places.SingleOrDefault(x => x.Name == end.Name) == null)
            {
                var lastPlace = path.Places.Last();
                Road shortestOutboundRoad = lastPlace.AllOutboundRoads.First(x => path.BeenThere(x.End) == false);
                foreach (var road in lastPlace.AllOutboundRoads)
                {
                    if (path.BeenThere(road.End) || shortestOutboundRoad.End == road.End)
                        continue;

                    if (shortestOutboundRoad.Distance > road.Distance)
                        shortestOutboundRoad = road;
                }
                
                path.AddPlace(shortestOutboundRoad.End);
            }

            return path;
        }

        public static Path FindRandomPath()
        {
            var start = Data.Places.Single(x => x.Name == "Home");
            var end = Data.Places.Single(x => x.Name == "School");

            var path = new Path();
            path.AddPlace(start);
            while (path.Places.SingleOrDefault(x => x.Name == end.Name) == null)
            {
                var lastPlace = path.Places.Last();
                var outboundRoadsWeHaventBeenTo = lastPlace.AllOutboundRoads.Where(x => path.BeenThere(x.End) == false);
                Random rand = new Random();
                var randomNumber = rand.Next(0, outboundRoadsWeHaventBeenTo.Count());

                Road randomOutboundRoad = outboundRoadsWeHaventBeenTo.ToArray()[randomNumber];
                path.AddPlace(randomOutboundRoad.End);
            }

            return path;
        }
    }
}