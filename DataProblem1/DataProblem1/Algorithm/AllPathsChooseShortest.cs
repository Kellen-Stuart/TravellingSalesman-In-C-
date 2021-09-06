using System.Collections.Generic;
using System.Linq;

namespace DataProblem1.Algorithm
{
    public class AllPathsChooseShortest : IAlgorithm
    {
        private Path _path;
        
        public AllPathsChooseShortest()
        {
            _path = new Path();
        }
        
        public Path FindPath(Place start, Place end)
        {
            // Run Algorithm
            var paths = FindAllPaths(start, end);
            
            // Pick the shortest path
            return paths.OrderByDescending(p => p.TotalDistance).FirstOrDefault();
        }

        public List<Path> FindAllPaths(Place start, Place end)
        {
            // Initialize Paths w/ Start Path
            var paths = new List<Path>();
            var startPath = new Path();
            startPath.AddPlace(start);
            paths.Add(startPath);
            
            var i = 0;
            while (paths.Any(x => x.EndOfPath().Name != end.Name) || i == paths.Count - 1)
            {
                var path = paths[i];
                while (path.EndOfPath().Name == end.Name)
                {
                    i++;
                    path = paths[i];
                }

                if (paths.Any(p => p.EndOfPath().Name == end.Name && p.TotalDistance < path.TotalDistance))
                {
                    paths.RemoveAt(i);
                    if (paths.Count == i)
                        return paths;
                    
                    path = paths[i];
                }
                
                var lastPlace = path.EndOfPath();
                foreach (var outboundRoad in lastPlace.AllOutboundRoads.Where(x => !path.BeenThere(x.End)))
                {
                    var newPath = new Path();
                    newPath.AddPlaces(path.Places);
                    newPath.AddPlace(outboundRoad.End);
                    paths.Add(newPath);
                }
                
                paths.RemoveAt(i);
            }

            return paths;
        }
    }
}