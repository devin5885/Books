using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// Simple graph class.
    /// </summary>
    public class Graph
    {
        // Maximum # of vertices.
        public const int NUM_VERTICES = 20;

        // Vertices.
        private Vertex[] vertices;
        private int numVerts;

        // Matrix of edges. 
        private int[,] adjMatrix;

        // Added: Whether this is a directed graph.
        // In a directed graph when an edge is added the adjaceny matrix is updated
        // symetrically (i.e.) both from and to the two vertexes. For a non-directed graph
        // only the from -> to edge is added.
        private bool directed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class.
        /// </summary>
        /// <param name="directedGraph">if set to <c>true</c> this is a directed graph (See above).
        /// </param>
        public Graph(bool directedGraph)
        {
            // Init params.
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            directed = directedGraph;

            // Initialize matrix
            for (int j = 0; j < NUM_VERTICES; j++)
                for (int k = 0; k < NUM_VERTICES; k++)
                    adjMatrix[j, k] = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Graph"/> class.
        /// Note: Added copy constructor to allow TopSort to not change the original object.
        /// </summary>
        /// <param name="graphSrc">The graph source.</param>
        public Graph(Graph graphSrc)
        {
            // Init vertices array.
            vertices = new Vertex[NUM_VERTICES];
            graphSrc.vertices.CopyTo(vertices, 0);

            numVerts = graphSrc.numVerts;
            directed = graphSrc.directed;

            // Initialize matrix.
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            for (int j = 0; j < NUM_VERTICES; j++)
                for (int k = 0; k < NUM_VERTICES; k++)
                    adjMatrix[j, k] = graphSrc.adjMatrix[j, k];
        }

        /// <summary>
        /// Adds a new vertex.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <returns>The index of the vertex.</returns>
        public int AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
            return numVerts - 1;
        }

        /// <summary>
        /// Adds an edge.
        /// </summary>
        /// <param name="start">The index of the starting (i.e.) 'from' vertex.</param>
        /// <param name="end">The index of the ending (i.e.) 'to' vertex.</param>
        public void AddEdge(int start, int end)
        {
            adjMatrix[start, end] = 1;

            // Only automatically add reverse edge for non-directed graph.
            if (!directed)
                adjMatrix[end, start] = 1;
        }

        /// <summary>
        /// Displays the vertex information to the console.
        /// </summary>
        /// <param name="v">The v.</param>
        public void ShowVertex(int v)
        {
            Console.Write(vertices[v].label + "\t");
        }

        /// <summary>
        /// Custom method that displays the adjacency matrix on the console.
        /// </summary>
        public void ShowAdjacencyMatrix()
        {
            // Show the header line(s).
            Console.WriteLine("Adjacency Matrix:");
            Console.Write("\t");
            for (int colIndex = 0; colIndex <= numVerts - 1; colIndex++)
                ShowVertex(colIndex);
            Console.WriteLine();

            // Show the rows.
            for (int rowIndex = 0; rowIndex <= numVerts - 1; rowIndex++)
            {
                ShowVertex(rowIndex);

                for (int colIndex = 0; colIndex <= numVerts - 1; colIndex++)
                    Console.Write(adjMatrix[rowIndex, colIndex] + "\t");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Returns true for the first found vertex with no successors (i.e.)
        /// a vertex with no "From" vertexes.
        /// </summary>
        /// <returns></returns>
        public int NoSuccessors()
        {
            // Init edge indicator.
            bool isEdge;

            // Look for a row with all zeros (No edges for vertex).
            for (int row = 0; row <= numVerts - 1; row++)
            {
                // Refresh edge indicator.
                isEdge = false;

                // Go thru the cols for the row, if non-zero is found this vertex
                // has a successor.
                for (int col = 0; col <= numVerts - 1; col++)
                    if (adjMatrix[row, col] > 0)
                    {
                        isEdge = true;
                        break;
                    }

                // Return this row if no successor was found.
                if (!(isEdge))
                    return row;
            }

            // No rows w/o successors found.
            return -1;
        }

        /// <summary>
        /// Deletes the vertex.
        /// </summary>
        /// <param name="vert">The vert.</param>
        public void DelVertex(int vert)
        {
            // Errata: Removed - This doesn't make sense.
            ////if (vert != numVerts - 1)
            ////{

            for (int j = vert; j <= numVerts - 1; j++)
                vertices[j] = vertices[j + 1];

            for (int row = vert; row <= numVerts - 1; row++)
                MoveRow(row, numVerts);

            for (int col = vert; col <= numVerts - 1; col++)
                MoveCol(col, numVerts - 1);

            // Errata: Added.
            // Reduce the # of vertices.
            numVerts--;

            // Errata: Removed.
            ////}
        }

        /// <summary>
        /// Simple topological sort. Displays the sorted list of nodes.
        /// Note: Updated to not change the original graph.
        /// </summary>
        public void TopSort()
        {
            // Init temp graph.
            Graph graphTemp = new Graph(this);

            // Init node label stack.
            Stack<string> gStack = new Stack<string>();

            // Errata - Not needed.
            ////int origVerts = numVerts;

            // Check all vertices.
            while (graphTemp.numVerts > 0)
            {
                // Find the next vertex w/o successors.
                int currVertex = graphTemp.NoSuccessors();

                // Check for no appropriate vertex found.
                if (currVertex == -1)
                {
                    Console.WriteLine("Error: graph has cycles.");
                    return;
                }

                // Store & delete the vertex.
                gStack.Push(vertices[currVertex].label);
                graphTemp.DelVertex(currVertex);
            }

            // Display:
            Console.Write("Topological sorting order: ");
            while (gStack.Count > 0)
                Console.Write(gStack.Pop() + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// Moves the row.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="length">The length.</param>
        private void MoveRow(int row, int length)
        {
            for (int col = 0; col <= length - 1; col++)
                adjMatrix[row, col] = adjMatrix[row + 1, col];
        }

        /// <summary>
        /// Moves the col.
        /// </summary>
        /// <param name="col">The col.</param>
        /// <param name="length">The length.</param>
        private void MoveCol(int col, int length)
        {
            for (int row = 0; row <= length - 1; row++)
                adjMatrix[row, col] = adjMatrix[row, col + 1];
        }
    }
}
