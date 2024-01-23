namespace Revvy_2
{
    public static class CheckSum
    {
        public static bool SearchSum(List<int> list, int N)
        {
            int middle = (list.Count - 1) / 2;

            HashSet<int> possibleSumsLeft = [];
            HashSet<int> possibleSumsRight = [];

            for (int i = 0; i < middle; i++)
            {
                HashSet<int> buffer = [];

                foreach (int sum in possibleSumsLeft)
                    buffer.Add(list[i] + sum);

                possibleSumsLeft.Add(list[i]);

                foreach (int bufSum in buffer)
                    possibleSumsLeft.Add(bufSum);
            }

            for (int i = middle; i < list.Count; i++)
            {
                HashSet<int> buffer = [];

                foreach (int set_element in possibleSumsRight)
                    buffer.Add(list[i] + set_element);

                possibleSumsRight.Add(list[i]);

                foreach (int bufSum in buffer)
                    possibleSumsRight.Add(bufSum);
            }

            foreach (int leftSum in possibleSumsLeft)
                if (possibleSumsRight.Contains(N - leftSum))
                    return true;

            return false;
        }
    }
}
