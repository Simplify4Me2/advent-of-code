using advent_of_code_2024_app.Day4;

namespace advent_of_code_2024_tests.Day4
{
    public class WordSearchTest
    {
        [Fact]
        public void Find()
        {
            WordSearch search = new();

            int result = search.Find("MXMXAXMASX");

            Assert.Equal(1, result);
        }

        [Fact]
        public void FindReversed()
        {
            WordSearch search = new();

            int result = search.Find("MSAMXMSMSA");

            Assert.Equal(1, result);
        }

        [Fact]
        public void FindBoth()
        {
            WordSearch search = new();

            int result = search.Find("XMASAMXAMM");

            Assert.Equal(2, result);
        }
    }
}
