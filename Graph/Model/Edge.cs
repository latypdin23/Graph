using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Model
{
    internal class Edge
    {
        public Vertex from;
        public Vertex to;
        public int weight;
        /// <summary>
        /// Инициализаует объет ребра между двумя заданными вершинами и с единичным весом весом
        /// </summary>
        /// <param name="from">Вершина A</param>
        /// <param name="to">Вершина B</param>
        /// <param name="weight">Вес</param>
        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            this.from = from;
            this.to = to;
            this.weight = weight;
        }
    }
}
