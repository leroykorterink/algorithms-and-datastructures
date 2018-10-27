namespace Graph
{
    public class Edge
    {
        public Vertex Destination;
        public double Cost;

        public Edge(Vertex destination, double cost)
        {
            Destination = destination;
            Cost = cost;
        }
    }
}