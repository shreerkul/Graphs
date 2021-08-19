
using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Dijkstra
    {
        public int[] DijkstraAlgorithm(Dictionary<int,Dictionary<int,int>> graph, int numNodes, int start, int end)
        {
            int[] dist = new int[numNodes];
            for (int i = 0; i < numNodes; i++)
            {
                dist[i] = Int32.MaxValue;
            }
            bool[] visited = new bool[numNodes];
            dist[0] = 0;
            var pq = new PriorityQueue<int, int>();
            pq.Enqueue(start,0);
            while (pq.Count >0)
            {
               pq.TryDequeue(out var node,out var weight);
               visited[node] = true;
               foreach (var item in graph[node])
               {
                   var newDist = dist[node] + item.Value;
                   if (newDist < dist[item.Key])
                   {
                       dist[item.Key] = newDist;
                       pq.Enqueue(item.Key,newDist);
                   }
               }
            }
            return dist;
        }
    }
}