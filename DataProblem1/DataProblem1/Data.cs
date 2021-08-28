using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataProblem1
{
    public static class Data
    {
        private static JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
        };

        private static string _jsonDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}\\JSON";

        public static List<Place> Places;
        public static List<Road> Roads;

        public static void InitializeData()
        {
            var pfc = System.IO.File.ReadAllText($"{_jsonDirectory}\\Places.json");
            var jsonPlaces = JsonSerializer.Deserialize<List<JSONPlace>>(pfc, _jsonSerializerOptions);
            var rfc = System.IO.File.ReadAllText($"{_jsonDirectory}\\Roads.json");
            var jsonRoads = JsonSerializer.Deserialize<List<JSONRoad>>(rfc, _jsonSerializerOptions);
            
            var places = new List<Place>();
            
            // Create Places
            foreach (var jPlace in jsonPlaces)
            {
                places.Add(new Place(jPlace.Name, jPlace.X, jPlace.Y));
            }

            // Create Roads
            var roads = new List<Road>();
            foreach (var jRoad in jsonRoads)
            {
                var road = new Road(places.Single(x => x.Name == jRoad.Start), places.Single(x => x.Name == jRoad.End));
                roads.Add(road);
            }

            // Associate Roads to Places
            foreach (var place in places)
            {
                foreach(var road in roads)
                {
                    if(road.Start.Name == place.Name)
                        place.AllOutboundRoads.Add(road);
                    
                    if (road.End.Name == place.Name)
                        place.AllInboundRoads.Add(road);
                }
            }

            Places = places;
            Roads = roads;
        }
    }
}