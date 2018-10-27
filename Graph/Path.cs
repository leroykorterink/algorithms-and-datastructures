using System;

namespace Graph
{
    public class Path : IComparable
    {
        public Vertex Destination;
        public double Cost;

        public Path(Vertex destination, double cost)
        {
            Destination = destination;
            Cost = cost;
        }

        /// <summary>
        /// Implementation of Comparable interface 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(object other)
        {
            var path = (Path) other;

            return Cost < path.Cost
                ? -1
                : Cost > path.Cost
                    ? 1
                    : 0;
        }
    }
}