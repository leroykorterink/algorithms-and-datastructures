namespace Graph
{
    public interface IGraph
    {
        Vertex GetVertex(string vertexName);

        void AddEdge(string sourceVertexName, string destinationVertexName, double cost);
        
        string ToString();
    }
}