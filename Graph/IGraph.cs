namespace Graph
{
    public interface IGraph
    {
        IVertex GetVertex(string vertexName);

        void AddEdge(string sourceVertexName, string destinationVertexName, double cost);
        
        string ToString();
    }
}