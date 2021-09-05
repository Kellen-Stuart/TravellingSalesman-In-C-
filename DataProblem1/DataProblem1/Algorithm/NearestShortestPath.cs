using System.Linq;

namespace DataProblem1.Algorithm
{
    public class NearestShortestPath : IAlgorithm
    {
        public Path FindPath(Place start, Place end)
        {
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
            throw new System.NotImplementedException();
        }
    }
}