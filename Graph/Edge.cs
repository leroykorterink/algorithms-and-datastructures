namespace Graph
{
    public class Edge
    {
        public IVertex Destination;
        public double Cost;

        public Edge(IVertex destination, double cost)
        {
            Destination = destination;
            Cost = cost;
        }
    }
}