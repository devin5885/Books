using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Chapter16.ConsoleApp.Pg293
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Page 293

            // Init the graph.
            Graph theGraph = new Graph(true);
            theGraph.AddVertex("CS1");
            theGraph.AddVertex("CS2");
            theGraph.AddVertex("DS");
            theGraph.AddVertex("OS");
            theGraph.AddVertex("ALG");
            theGraph.AddVertex("AL");
            theGraph.AddEdge(0, 1);
            theGraph.AddEdge(1, 2);
            theGraph.AddEdge(1, 5);
            theGraph.AddEdge(2, 3);
            theGraph.AddEdge(2, 4);

            // Display the matrix.
            theGraph.ShowAdjacencyMatrix();

            // Sort the graph.
            theGraph.TopSort();

            // Finished.
            Console.WriteLine("Finished.");
            Console.ReadKey();
        }
    }
}
