using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Model
{
    internal class Vertex
    {
        public int number { get; set; }
        /// <summary>
        /// Инициализирует объект вершины графа с заданным номером
        /// </summary>
        /// <param name="number"></param>
        public Vertex(int number)
        {
            this.number = number;
        }
    }
}
