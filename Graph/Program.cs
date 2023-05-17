using Graph.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Какой алгоритм продемонстрировать:\n" +
               "1. Нажмитие 1 для просмотра DFS рекурсии;\n" +
               "2. Нажмите 2 для просмотра DFS стек; \n" +
               "3. Нажмите 3 для просмотр BFS\n");
            int algorithm = -1;
            if (!int.TryParse(Console.ReadLine(), out algorithm))
            {
                Console.WriteLine("Неверный ввод");
            }
            else
            {
                ShowGraphAlogorthms(algorithm);
            }

            Console.ReadLine();
        }
        static void ShowGraphAlogorthms(int algorthm)
        {
            Model.Graph myGraph = new Model.Graph();

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

            myGraph.CreateAdjacencyList();

            myGraph.AddEdge(v0, v1);
            myGraph.AddEdge(v0, v2);
            myGraph.AddEdge(v2, v3);
            myGraph.AddEdge(v1, v4);
            myGraph.AddEdge(v1, v5);
            myGraph.AddEdge(v4, v5);
            myGraph.AddEdge(v5, v4);

            myGraph.ShowAdjacencyList();

            List<int> path = new List<int>();
           
            switch(algorthm)
            {
                case 1:
                    Console.WriteLine("\nDFS рекурсия: ");
                    myGraph.DFS(v0);
                    break;
                case 2:
                    Console.WriteLine("\nDFS стек: ");
                    myGraph.DFS(v0.number, path);
                    break;
                case 3:
                    Console.WriteLine("\nBFS: ");
                    myGraph.BFS(v0.number, path);
                    break;
                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
        }
    }
}
