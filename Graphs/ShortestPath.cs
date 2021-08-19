using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class ShortestPath
    {
        public ShortestPath()
        {
            
        }
        public void FindUsingDijkstras(Dictionary<int,Dictionary<int,int>> graph,int numNodes,int start, int end)
        {
            var dijkstras = new Dijkstra();
           int[] distance = dijkstras.DijkstraAlgorithm(graph, numNodes, start, end);
           
           foreach (var t in distance)
           {
               Console.WriteLine(t);
           }
        }
    }
}