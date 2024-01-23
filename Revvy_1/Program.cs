namespace Revvy_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder                       
                            .AddOfficial(2, [3, 4])
                            .AddOfficial(1, [2])
                            .AddOfficial(3, [5, 4])
                            .Build();


            var result = group.GetAllDocuments();

            Console.WriteLine(string.Join(", ", result));
            
        }


    }
}
