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
            // Initialize Paths
            var paths = new List<Path>();
            var startPath = new Path();
            startPath.AddPlace(start);
            paths.Add(startPath);
            
            // Run Algorithm
            paths = FindPath(paths, end);
            
            // Pick the shortest path
            return paths.OrderByDescending(p => p.TotalDistance).FirstOrDefault();
        }

        public List<Path> FindPath(List<Path> paths, Place end)
        {
            for (var i=0; i<paths.Count; i++)
            {
                var path = paths[i];
                while (paths.All(x => x.EndOfPath().Name != end.Name))
                {
                    path = paths[i];
                    while (path.EndOfPath().Name == end.Name)
                        i++;
                    
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
            }

            return paths;
        }
    }
}