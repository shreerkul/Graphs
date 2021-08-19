using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            var shortestPath = new ShortestPath();
            shortestPath.FindUsingDijkstras(graph.graph,5,0,4);
            Console.Read();
        }
    }
}