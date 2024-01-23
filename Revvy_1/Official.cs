namespace Revvy_1
{
  internal class Official
  {
    public int Id { get; set; }
    public List<int> RequiredIds { get; set; }

    public Official(int id,  List<int> requiredIds)
    {
      Id = id;
      RequiredIds = requiredIds;
    }
  }
}
