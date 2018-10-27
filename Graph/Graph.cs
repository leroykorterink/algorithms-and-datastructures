using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using PriorityQueue;

namespace Graph
{
    public class Graph : IGraph
    {
        public const double Infinity = double.MaxValue;

        protected Dictionary<string, Vertex> VertexMap = new Dictionary<string, Vertex>();

        /// <summary>
        /// Try to get the vertex by vertex name, if it does not exist create a
        /// new one and add it to the vertex map
        /// </summary>
        /// <param name="vertexName"></param>
        /// <returns></returns>
        public IVertex GetVertex(string vertexName)
        {
            if (VertexMap.TryGetValue(vertexName, out var vertex)) return vertex;

            vertex = new Vertex(vertexName);
            VertexMap.Add(vertexName, vertex);

            return vertex;
        }

        public void AddEdge(string sourceVertexName, string destinationVertexName, double cost)
        {
            var sourceVertex = (Vertex) GetVertex(sourceVertexName);
            var destinationVertex = GetVertex(destinationVertexName);

            sourceVertex.AdjacentVertices.Add(new Edge(destinationVertex, cost));
        }

        /// <summary>
        /// Initializes the vertex output info prior to running any shortest path algorithm
        /// </summary>
        protected void ClearAll()
        {
            foreach (var vertex in VertexMap.Values)
                vertex.Reset();
        }

        /// <summary>
        /// Method used to print vertices in a path
        /// </summary>
        /// <param name="destination"></param>
        /// <returns></returns>
        protected string PathToString(Vertex destination)
        {
            var result = "";

            if (destination.PreviousVertex != null)
                result += " to " + PathToString(destination.PreviousVertex);

            return destination.Name + result;
        }

        /// <summary>
        /// Method used to print a path
        /// </summary>
        /// <param name="destinationName"></param>
        /// <returns></returns>
        /// <exception cref="NoSuchElementException"></exception>
        public string PathToString(string destinationName)
        {
            if (!VertexMap.TryGetValue(destinationName, out var vertex))
                throw new NoSuchElementException();

            if (vertex.Distance == Infinity)
                return destinationName + " is unreachable";

            return $"(Cost is: {vertex.Distance}) {PathToString(vertex)}";
        }


        public override string ToString()
        {
            throw new NotImplementedException();
        }

        #region Shortest-path algorithms

        /// <summary>
        /// Single source unweighted shortest-path algorithm
        /// </summary>
        /// <param name="startVertexName"></param>
        /// <exception cref="NoSuchElementException"></exception>
        public void Unweighted(string startVertexName)
        {
            ClearAll();

            if (!VertexMap.TryGetValue(startVertexName, out var start))
                throw new NoSuchElementException();

            var queue = new Queue<Vertex>();

            // Add start vertex to queue
            queue.Enqueue(start);
            start.Distance = 0;

            while (queue.Count != 0)
            {
                var currentVertex = queue.Dequeue();
                
                // Set visited to true so we can check if the graph is connected or not
                currentVertex.Visited = true;

                currentVertex.AdjacentVertices.ForEach(edge =>
                {
                    var adjacentVertex = (Vertex) edge.Destination;

                    if (adjacentVertex.Distance != Infinity) return;

                    adjacentVertex.Distance = currentVertex.Distance + 1;
                    adjacentVertex.PreviousVertex = currentVertex;

                    queue.Enqueue(adjacentVertex);
                });
            }
        }

        public void Dijkstra(string startVertexName)
        {
            ClearAll();

            if (!VertexMap.TryGetValue(startVertexName, out var start))
                throw new NoSuchElementException();

            var priorityQueue = new PriorityQueue<Path>();

            // Add start path to priority queue
            priorityQueue.Enqueue(new Path(start, 0));
            start.Distance = 0;

            var nodesSeen = 0;
            while (!priorityQueue.IsEmpty() && nodesSeen < VertexMap.Count)
            {
                var vertexRecord = priorityQueue.Dequeue();
                var vertex = vertexRecord.Destination;

                // Don't revisit vertex
                if (vertex.Visited) continue;

                vertex.Visited = true;
                nodesSeen++;

                vertex.AdjacentVertices.ForEach(edge =>
                {
                    var adjacentVertex = (Vertex) edge.Destination;
                    var edgeCost = edge.Cost;

                    if (edgeCost < 0)
                        throw new GraphException("Graph has negative edges");

                    // Don't update the distance of to the adjacent vertex when the distance is higher
                    if (!(vertex.Distance + edgeCost < adjacentVertex.Distance))
                        return;

                    adjacentVertex.Distance = vertex.Distance + edgeCost;
                    adjacentVertex.PreviousVertex = vertex;

                    priorityQueue.Enqueue(new Path(adjacentVertex, adjacentVertex.Distance));
                });
            }
        }

        #endregion

        public bool IsConnected()
        {
            Unweighted(VertexMap.First().Value.Name);            
            
            foreach (var vertex in VertexMap.Values)
                // Return false when any vertex has not been visited
                if (!vertex.Visited)
                    return false;

            return true;
        }
    }

    #region Custom error classes

    internal class NoSuchElementException : Exception
    {
    }

    internal class GraphException : Exception
    {
        internal GraphException(string message) : base(message)
        {
        }
    }

    #endregion
}