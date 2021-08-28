namespace DataProblem1
{
    public class JSONPlace
    {
        public JSONPlace(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }

        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}