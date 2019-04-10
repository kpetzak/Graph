﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class GraphComponents
    {
        public static Graph graph = new Graph(new List<int>[]
        {
            new List<int>() {4},       // successors of vertice 0
            new List<int>() {1, 2, 6}, // successors of vertice 1
            new List<int>() {1, 6},    // successors of vertice 2
            new List<int>() {6},       // successors of vertice 3
            new List<int>() {0},       // successors of vertice 4
            new List<int>() {},        // successors of vertice 5
            new List<int>() {1, 2, 3}  // successors of vertice 6
        });

        public static bool[] visited = new bool[graph.Size];

        public static void TraverseDFS(int v)
        {
            if (!visited[v])
            {
                Console.Write(v + " ");
                visited[v] = true;

                foreach (int child in graph.GetSuccessors(v))
                {
                    TraverseDFS(child);
                }
            }
        }

    }
}
