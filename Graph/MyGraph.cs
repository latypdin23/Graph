using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class MyGraph
    {
        private List<Vertex> V = new List<Vertex>();
        private List<Edge> E = new List<Edge>();

        private List<Vertex>[] adjList;
        private bool[] visited;
        public int VertexCount => V.Count;
        public void CreateAdjList()
        {
            visited = new bool[VertexCount];
            adjList = new List<Vertex>[VertexCount];
            for (int i = 0; i < VertexCount; i++)
            {
                adjList[i] = new List<Vertex>();
            }

        }
        public void AddVertex(Vertex v)
        {
            V.Add(v);
        }
        public void AddEdge(Vertex from, Vertex to)
        {
            adjList[from.number].Add(to);
        }
        public void ShowAdjList()
        {
            for(int i=0;i<VertexCount;i++)
            {
                Console.Write(i + ": ");
                foreach(Vertex v in adjList[i])
                {
                    Console.Write(v.number + ", ");
                }
                Console.WriteLine();
            }
        }
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
        
        public void DFS2(int v, List<int> path)
        {
            Stack<int> s=new Stack<int>();

            visited[v] = true;
            s.Push(v);
            while (s.Count!=0)
            {
                int top = s.Peek();
                visited[top] = true;
                Console.Write( top + " ->");
                path.Add(top);
                s.Pop();

                foreach(Vertex vertex in adjList[top])
                {
                    if (!visited[vertex.number])
                    {
                        s.Push(vertex.number);
                        visited[vertex.number] = true;
                    }
                }
            }

        }
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

        public int[,] GetAdjMatrix()
        {
            var result = new int[VertexCount, VertexCount];

            foreach(Edge e in E)
            {
                int row = e.from.number;
                int column = e.to.number;
                result[row, column] = e.weight;
            }
            return result;
        }

        
    }
}
