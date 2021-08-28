using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataProblem1
{
    public class Place
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public Point Point => new Point(X, Y);
        public List<Road> AllInboundRoads;
        public List<Road> AllOutboundRoads;

        public Place(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
            AllInboundRoads = new List<Road>();
            AllOutboundRoads = new List<Road>();
        }

        public override string ToString()
        {
            var newLine = Environment.NewLine;
            var str = $"Name: {Name}{newLine}" +
                $"Point: {Point}{newLine}";

            foreach (var outboundRoad in AllOutboundRoads)
                str += $"Outbound Road: {outboundRoad}{newLine}";

            foreach (var inboundRoad in AllInboundRoads)
                str += $"Inbound Road: {inboundRoad}{newLine}";

            return str;
        }
    }
    public static class PlaceExtensions
    {
        public static double CalculateDistance(this Place placeA, Place placeB)
        {
            return placeA.Point.CalculateDistance(placeB.Point);
        }
    }
}