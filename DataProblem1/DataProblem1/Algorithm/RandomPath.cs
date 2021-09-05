using System;
using System.Linq;

namespace DataProblem1
{
    public class RandomPath : IAlgorithm
    {
        public Path FindPath(Place start, Place end)
        {
            var path = new Path();
            path.AddPlace(start);
            while (path.Places.SingleOrDefault(x => x.Name == end.Name) == null)
            {
                var lastPlace = path.Places.Last();
                var outboundRoadsWeHaventBeenTo = lastPlace.AllOutboundRoads.Where(x => path.BeenThere(x.End) == false);
                var rand = new Random();
                var randomNumber = rand.Next(0, outboundRoadsWeHaventBeenTo.Count());

                Road randomOutboundRoad = outboundRoadsWeHaventBeenTo.ToArray()[randomNumber];
                path.AddPlace(randomOutboundRoad.End);
            }

            return path;
        }
    }
}