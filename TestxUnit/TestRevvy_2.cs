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
            List<int> list = [3, 1, 8, 5, 4];

            var result = CheckSumContext.Check(list, 10);
            var expected = true;

            Assert.Equal(expected, result);
        }
    }
}
