using System;
using System.Collections.Generic;
using System.Linq;

namespace DataProblem1
{
    public class Path
    {
        public List<Place> Places = new List<Place>();
        public double TotalDistance = 0;

        public void AddPlace(Place place)
        {
            if (Places.Count >= 1)
            {
                TotalDistance += Places.Last().CalculateDistance(place);
            }
            Places.Add(place);   
        }

        public bool BeenThere(Place place)
        {
            foreach (var placeWeveBeen in Places)
            {
                if (placeWeveBeen.Name == place.Name)
                    return true;
            }

            return false;
        }

        public override string ToString()
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
    }
}