using System.Collections.Generic;

namespace Graph
{
    public class Vertex : IVertex
    {
        public string Name;
        public double Distance;

        public List<Edge> AdjacentVertices = new List<Edge>();
        public Vertex PreviousVertex; // Previous vertex on *shortest* path

        // Variable used in path finding algorithms
        public bool Visited;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Vertex(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Reset()
        {
            Distance = Graph.Infinity;
            PreviousVertex = default(Vertex);
            Visited = false;
        }
    }
}