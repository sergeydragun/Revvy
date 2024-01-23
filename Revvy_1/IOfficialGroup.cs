namespace Revvy_1
{
    public interface IOfficialGroup
    {
        void AddGraphInfo(Dictionary<int, List<int>> officialGraph);
        List<int> GetAllDocuments();
    }
}
