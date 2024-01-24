namespace Revvy_1
{
    public class OfficialGroupBuilder<T>
        where T : IOfficialGroup, new()
    {
        private List<Official> _officials = [];
        private Dictionary<int, List<int>> _officialGraph = [];

        public OfficialGroupBuilder<T> AddOfficial(int id, List<int> requiredIds)
        {
            var official = new Official(id, requiredIds);
            _officials.Add(official);
            return this;
        }

        public T Build()
        {
            var graph = GetGraph();

            var officialGroup = new T();
            officialGroup.AddGraphInfo(graph);
            _officials = []; //инициализируем коллекцию чтобы обнулить поля

            return officialGroup;
        }

        private Dictionary<int, List<int>> GetGraph()
        {
            var graph = new Dictionary<int, List<int>>();

            foreach (var official in _officials)
            {
                graph[official.Id] = official.RequiredIds;

                foreach (var id in official.RequiredIds)
                {
                    if (!graph.ContainsKey(id))
                        graph.Add(id, []);
                }
            }

            return graph;
        }
    }
}
