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
            Console.WriteLine("Connected graph components: ");

            for (int v = 0; v < GraphComponents.graph.Size; v++)
            {
                if (!GraphComponents.visited[v])
                {
                    GraphComponents.TraverseDFS(v);
                    Console.WriteLine();
                }
            }
        }
    }
}
