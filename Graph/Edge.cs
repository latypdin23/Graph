using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Edge
    {
        public Vertex from;
        public Vertex to;
        public int weight;
        public Edge(Vertex from, Vertex to, int weight=1)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }
    }
}
