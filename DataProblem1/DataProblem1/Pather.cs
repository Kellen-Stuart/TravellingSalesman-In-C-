using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataProblem1
{
    public class Pather
    {
        public IEnumerable<Road> FindAPath(Place start, Place end, IEnumerable<Road> roads)
        {
            var startingRoads = roads.Where(x => x.Start == start.Name);
        }
    }
}