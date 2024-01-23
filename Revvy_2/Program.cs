namespace Revvy_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = [3, 1, 8, 5, 4];
            var result = CheckSumContext.Check(list, 2);
            var result2 = CheckSumContext.Check(list, 10);

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
