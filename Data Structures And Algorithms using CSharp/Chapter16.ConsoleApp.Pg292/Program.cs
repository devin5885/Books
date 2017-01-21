using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Chapter16.ConsoleApp.Pg292
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Page 292

            // Init the graph.
            Graph theGraph = new Graph(true);
            theGraph.AddVertex("A");
            theGraph.AddVertex("B");
            theGraph.AddVertex("C");
            theGraph.AddVertex("D");
            theGraph.AddEdge(0, 1);
            theGraph.AddEdge(1, 2);
            theGraph.AddEdge(2, 3);
            theGraph.AddEdge(3, 4);

            // Display.
            theGraph.ShowAdjacencyMatrix();

            // Sort.
            theGraph.TopSort();

            // Done.
            Console.WriteLine("Finished.");
            Console.ReadKey();
        }
    }
}
