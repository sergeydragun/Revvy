using Revvy_1;

namespace TestxUnit
{
    public class TestRevvy_1
    {
        [Fact]
        public void TestGetAllDocuments_12_234()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(1, [2])
                .AddOfficial(2, [3, 4])
                .Build();

            List<int> expected = [3, 4, 2, 1];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAllDocuments_12_34()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(1, [2])
                .AddOfficial(3, [4])
                .Build();

            List<int> expected = [2, 4, 1, 3];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAllDocuments_12_234_357()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(1, [2])
                .AddOfficial(2, [3, 4])
                .AddOfficial(3, [5, 7])
                .Build();

            List<int> expected = [4, 5, 7, 3, 2, 1];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAllDocuments_324_53()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(3, [2, 4])
                .AddOfficial(5, [3])
                .Build();

            List<int> expected = [2, 4, 3, 5];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAllDocuments_53_324()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(5, [3])
                .AddOfficial(3, [2, 4])
                .Build();

            List<int> expected = [2, 4, 3, 5];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAllDocuments_234_12()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(2, [3, 4])
                .AddOfficial(1, [2])
                .Build();

            List<int> expected = [3, 4, 2, 1];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetAllDocuments_234_12_354()
        {
            var builder = new OfficialGroupBuilder<OfficialGroup>();

            var group = builder
                .AddOfficial(2, [3, 4])
                .AddOfficial(1, [2])
                .AddOfficial(3, [5, 4])
                .Build();

            List<int> expected = [4, 5, 3, 2, 1];
            var actual = group.GetAllDocuments();

            Assert.Equal(expected, actual);
        }
    }
}