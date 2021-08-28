using System.Collections.Generic;
using System.Linq;

namespace DataProblem1
{
    public class Road
    {
        public Place Start { get; }
        public Place End { get; }
        
        public double Distance => Start.CalculateDistance(End);

        public Road(Place start, Place end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return $"{Start.Name} => {End.Name}";
        }
    }
}