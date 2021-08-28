namespace DataProblem1
{
    public class Place
    {
        public string Name { get; set; }
        public Point Point { get; set; }
        
        public Place(string name, Point point)
        {
            Name = name;
            Point = point;
        }
    }
}