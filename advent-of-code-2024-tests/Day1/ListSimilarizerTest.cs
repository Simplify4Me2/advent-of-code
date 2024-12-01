using advent_of_code_2024_app.Day1;

namespace advent_of_code_2024_tests.Day1
{
    public class ListSimilarizerTest
    {
        [Fact]
        public void CalculateSum_ReturnsSumOfOccurences()
        {
            var leftList = new List<int> { 3, 4, 2, 1, 3, 3 };
            var rightList = new List<int>() { 4, 3, 5, 3, 9, 3 };

            ListSimilarizer similarizer = new(leftList, rightList);

            Assert.Equal(31, similarizer.CalculateSum());
        }
    }
}
