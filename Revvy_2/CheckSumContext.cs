namespace Revvy_2
{
    public static class CheckSumContext
    {
        public static bool Check<T>(List<T> list, int N)
             where T : struct
        {
            switch (list)
            {
                case List<int> listInt:
                    return CheckSum.SearchSum(listInt, N);
                default:
                    throw new InvalidOperationException();
            } 
        }
    }
}
