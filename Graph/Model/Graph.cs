using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph.Model
{
    internal class Graph
    {
        private List<Vertex> V = new List<Vertex>();
        private List<Edge> E = new List<Edge>();

        private List<Vertex>[] adjList;
        private int[,] adjMatrix;
        private bool[] visited;
        public int VertexCount => V.Count;
        /// <summary>
        /// Формируется лист смежности
        /// </summary>
        public void CreateAdjacencyList()
        {
            visited = new bool[VertexCount];
            adjList = new List<Vertex>[VertexCount];
            for (int i = 0; i < VertexCount; i++)
            {
                adjList[i] = new List<Vertex>();
            }

        }
        /// <summary>
        /// Выводит лист смежности на консоль
        /// </summary>
        public void ShowAdjacencyList()
        {
            for (int i = 0; i < VertexCount; i++)
            {
                Console.Write(i + ": ");
                foreach (Vertex v in adjList[i])
                {
                    Console.Write(v.number + ", ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Получает матрицу смежности
        /// </summary>
        /// <returns></returns>
        public void CreateAdjacencyMatrix()
        {
            adjMatrix = new int[VertexCount, VertexCount];

            foreach (Edge e in E)
            {
                int row = e.from.number;
                int column = e.to.number;
                adjMatrix[row, column] = e.weight;
            }
        }
        public void ShowAdjacencyMatrix()
        {
            Console.Write(" ");
            for (int j = 0; j < VertexCount; j++)
            {

                Console.Write(" | " + (j + 1).ToString() + " | ");
            }
            Console.WriteLine("\n_________________________________________________");
            for (int i = 0; i < VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < VertexCount; j++)
                {
                    Console.Write(" | " + adjMatrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Добавляет вершину в граф
        /// </summary>
        /// <param name="v"></param>
        public void AddVertex(Vertex v)
        {
            V.Add(v);
        }
        /// <summary>
        /// Добавляет ребро в граф
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddEdge(Vertex from, Vertex to)
        {
            adjList[from.number].Add(to);
        }
        /// <summary>
        /// Обход в глубину
        /// </summary>
        /// <param name="vertex"></param>
        public void DFS(Vertex vertex)
        {
            visited[vertex.number] = true;
            Console.Write(vertex.number + " -> ");
            List<Vertex> tmp = adjList[vertex.number];
            foreach (Vertex v in tmp)
            {
                if (!visited[v.number])
                {
                    DFS(v);
                }
            }
        }
        /// <summary>
        /// Обход в глубину 2 способ
        /// </summary>
        /// <param name="v"></param>
        /// <param name="path"></param>
        public void DFS(int v, List<int> path)
        {
            Stack<int> s = new Stack<int>();

            visited[v] = true;
            s.Push(v);
            while (s.Count != 0)
            {
                int top = s.Peek();
                visited[top] = true;
                Console.Write(top + " ->");
                path.Add(top);
                s.Pop();

                foreach (Vertex vertex in adjList[top])
                {
                    if (!visited[vertex.number])
                    {
                        s.Push(vertex.number);
                        visited[vertex.number] = true;
                    }
                }
            }

        }
        /// <summary>
        /// Обход в ширину
        /// </summary>
        /// <param name="v"></param>
        /// <param name="path"></param>
        public void BFS(int v, List<int> path)
        {
            Queue<int> s = new Queue<int>();

            visited[v] = true;
            s.Enqueue(v);
            while (s.Count != 0)
            {
                int top = s.Peek();
                visited[top] = true;
                Console.Write(top + " ->");
                path.Add(top);
                s.Dequeue();

                foreach (Vertex vertex in adjList[top])
                {
                    if (!visited[vertex.number])
                    {
                        s.Enqueue(vertex.number);
                        visited[vertex.number] = true;
                    }
                }
            }

        }
       
    }
}
