using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
namespace Revvy_1
{
    internal class OfficialGroup : IOfficialGroup
    {
        private Dictionary<int, List<int>> _officialGraph;

        public void AddGraphInfo(Dictionary<int, List<int>> officialGraph)
        {
            _officialGraph = officialGraph;
        }

        public List<int> GetAllDocuments()
        {
            var result = new List<int>();
            var visited = new HashSet<int>();
            var queue = new Queue<int>();

            foreach (var key in _officialGraph.Keys)
            {
                if (_officialGraph[key].Count == 0)
                {
                    queue.Enqueue(key);
                    visited.Add(key);
                }
            }

            while (queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                result.Add(vertex);

                if (_officialGraph.ContainsKey(vertex))
                {
                    var nextNeighbors = _officialGraph.Keys.Where(n => _officialGraph[n].Contains(vertex));
                    foreach (var neighbor in nextNeighbors)
                    {
                        if (visited.Contains(neighbor))                      
                            continue;
                                           

                        var allDependenciesVisited = true;
                        foreach (var dependency in _officialGraph[neighbor])
                        {
                            if (!visited.Contains(dependency))
                            {
                                allDependenciesVisited = false;
                                break;
                            }
                        }

                        if (allDependenciesVisited)
                        {
                            visited.Add(neighbor);
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return result;
        }
    }
}
