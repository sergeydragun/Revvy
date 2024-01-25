namespace Revvy_2
{
    public static class CheckSum
    {
        public static bool SearchSum(List<int> list, int N)
        {
            HashSet<int> possibleSums = [];

            for (int i = 0; i < list.Count; i++)
            {
                HashSet<int> buffer = [];

                foreach (int sum in possibleSums)
                    buffer.Add(list[i] + sum);

                possibleSums.Add(list[i]);

                foreach (int bufSum in buffer)
                    possibleSums.Add(bufSum);
            }

            return possibleSums.Contains(N);
        }
    }
}
