using Revvy_2;

namespace TestxUnit
{
    public class TestRevvy_2
    {
        [Fact]
        public void TestCheckSum_31854_2_false()
        {
            List<int> list = [3, 1, 8, 5, 4];

            var result = CheckSumContext.Check(list, 2);
            var expected = false;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_31854_10_true()
        {
            List<int> list = [10, 9, 8, 7, 6];

            var result = CheckSumContext.Check(list, 19);
            var expected = true;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_EmptyList_False()
        {
            var list = new List<int>();

            var result = CheckSumContext.Check(list, 10);
            var expected = false;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_SingleItemInList_False()
        {
            var list = new List<int> { 5 };

            var result = CheckSumContext.Check(list, 10);
            var expected = false;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_SumOfTwoNumbersInList_True()
        {
            var list = new List<int> { 3, 7 };

            var result = CheckSumContext.Check(list, 10);
            var expected = true;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_SumOfMultipleNumbersInList_True()
        {
            var list = new List<int> { 1, 2, 3, 4 };

            var result = CheckSumContext.Check(list, 7);
            var expected = true;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_SumOfAllNumbersInList_True()
        {
            var list = new List<int> { 1, 2, 3, 4 };

            var result = CheckSumContext.Check(list, 10);
            var expected = true;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_SumOfNumbersInList_True()
        {
            var list = new List<int> { 1, 2, 3, 4 };

            var result = CheckSumContext.Check(list, 7);
            var expected = true;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_NegativeNumbersInList_True()
        {
            var list = new List<int> { 1, -2, 3, -4 };

            var result = CheckSumContext.Check(list, -1);
            var expected = true;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCheckSum_ZeroInList_True()
        {
            var list = new List<int> { 1, 0, 3, 4 };

            var result = CheckSumContext.Check(list, 0);
            var expected = true;

            Assert.Equal(expected, result);
        }

    }
}
