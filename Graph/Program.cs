using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGraph myGraph = new MyGraph();

            Vertex v0 = new Vertex(0);
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);
            Vertex v6 = new Vertex(6);
            myGraph.AddVertex(v0);
            myGraph.AddVertex(v1);
            myGraph.AddVertex(v2);
            myGraph.AddVertex(v3);
            myGraph.AddVertex(v4);
            myGraph.AddVertex(v5);
            myGraph.AddVertex(v6);
            
            myGraph.CreateAdjList();

            myGraph.AddEdge(v0, v1);
            myGraph.AddEdge(v0, v2);
            myGraph.AddEdge(v2, v3);
            myGraph.AddEdge(v1, v4);
            myGraph.AddEdge(v1, v5);
            myGraph.AddEdge(v4, v5);
            myGraph.AddEdge(v5, v4);

            myGraph.ShowAdjList();

            List<int> path = new List<int>();

            Console.WriteLine("DFS  рекурсия: ");
            myGraph.DFS(v0);

            //Console.WriteLine("\nDFS стек: ");
            //myGraph.DFS2(v0.number, path);

            //Console.WriteLine("\nBFS: ");
            //myGraph.BFS(v0.number, path);

            Console.ReadLine();
        }
        private static void ShowAdjMatrix(MyGraph myGraph, int[,] adjMatrix)
        {
            Console.Write(" ");
            for (int j = 0; j < myGraph.VertexCount; j++)
            {

                Console.Write(" | " + (j + 1).ToString() + " | ");
            }
            Console.WriteLine("\n_________________________________________________");
            for (int i = 0; i < myGraph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < myGraph.VertexCount; j++)
                {
                    Console.Write(" | " + adjMatrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
