using System.Collections.Generic;

namespace Graphs
{
    public class Graph
    {
        public Dictionary<int,Dictionary<int,int>> graph;

        public Graph()
        {
            graph = new Dictionary<int, Dictionary<int, int>>
            {
                {0,new Dictionary<int, int>(){ {1,4},{2,1}}},
                {1,new Dictionary<int, int>(){ {3,1}}},
                {2,new Dictionary<int, int>(){ {1,2},{3,5}}},
                {3,new Dictionary<int, int>(){ {4,3}}},
                {4,new Dictionary<int, int>()}
            };

        }
    }
}