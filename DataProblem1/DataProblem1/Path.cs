using System;
using System.Collections.Generic;
using System.Linq;

namespace DataProblem1
{
    public class Path
    {
        public List<Place> Places = new List<Place>();
        public double TotalDistance = 0;
        public string Id => string.Join(string.Empty, Places.Select(x => x.Name));

        public void AddPlace(Place place)
        {
            if (Places.Count >= 1)
            {
                TotalDistance += Places.Last().CalculateDistance(place);
            }
            Places.Add(place);   
        }

        public void AddPlaces(IEnumerable<Place> places)
        {
            Places.AddRange(places);
        }

        public bool BeenThere(Place place)
        {
            return Places.Any(x => x.Name == place.Name);
        }

        public Place EndOfPath()
        {
            if (!Places.Any())
                return null;

            return Places.Last();
        }

        public string ToStringVerbose()
        {
            var str = string.Empty;
            var newLine = Environment.NewLine;

            for (var i=0; i < Places.Count; i++)
            {
                var place = Places[i];
                if(i == Places.Count - 1)
                    str += $"{place.Name}";
                else
                    str += $"{place.Name} => ";
            }

            str += $"{newLine}Total Distance: {TotalDistance}";

            return str;
        }
        

        public override string ToString()
        {
            var str = string.Empty;

            for (var i=0; i < Places.Count; i++)
            {
                var place = Places[i];
                if(i == Places.Count - 1)
                    str += $"{place.Name}";
                else
                    str += $"{place.Name} => ";
            }

            return str;
        }
    }
}