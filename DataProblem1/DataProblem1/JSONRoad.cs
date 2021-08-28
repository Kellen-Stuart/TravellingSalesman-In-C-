namespace DataProblem1
{
    public class JSONRoad
    {
        public string Start { get; set; }
        public string End { get; set; }

        public JSONRoad(string start, string end)
        {
            Start = start;
            End = end;
        }
    }
}