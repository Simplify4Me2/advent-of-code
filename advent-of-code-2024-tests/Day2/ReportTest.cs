using advent_of_code_2024_app.Day2;

namespace advent_of_code_2024_tests.Day2
{
    public class ReportTest
    {
        [Fact]
        public void AllLevelsIncrease_ReturnsTrue()
        {
            List<int> levels = [1, 3, 6, 7, 9];

            Report report = new(levels);

            Assert.True(report.IsSafe);
        }

        [Fact]
        public void AllLevelsDecrease_ReturnsTrue()
        {
            List<int> levels = [7, 6, 4, 2, 1];

            Report report = new(levels);

            Assert.True(report.IsSafe);
        }

        [Fact]
        public void AllLevelsDecrease_AdjacentLevelsDifferLessThanOne_ReturnsFalse()
        {
            List<int> levels = [8, 6, 4, 4, 1];

            Report report = new(levels);

            Assert.False(report.IsSafe);
        }

        [Fact]
        public void AllLevelsDecrease_AdjacentLevelsDifferMoreThanThree_ReturnsFalse()
        {
            List<int> levels = [1, 2, 7, 8, 9];

            Report report = new(levels);

            Assert.False(report.IsSafe);
        }

        [Theory]
        [InlineData(new int[] { 7, 6, 4, 2, 1 }, true)]
        [InlineData(new int[] { 1, 2, 7, 8, 9 }, false)]
        [InlineData(new int[] { 9, 7, 6, 2, 1 }, false)]
        [InlineData(new int[] { 1, 3, 2, 4, 5 }, false)]
        [InlineData(new int[] { 8, 6, 4, 4, 1 }, false)]
        [InlineData(new int[] { 1, 3, 6, 7, 9 }, true)]
        [InlineData(new int[] { 2, 4, 6, 9, 10, 9 }, false)]
        public void IsSafe(int[] levels, bool isSafe)
        {
            Report report = new([.. levels]);

            Assert.Equal(isSafe, report.IsSafe);
        }

        [Theory]
        [InlineData(new int[] { 7, 6, 4, 2, 1 }, true)]
        [InlineData(new int[] { 1, 2, 7, 8, 9 }, false)]
        [InlineData(new int[] { 9, 7, 6, 2, 1 }, false)]
        [InlineData(new int[] { 1, 3, 2, 4, 5 }, true)]
        [InlineData(new int[] { 8, 6, 4, 4, 1 }, true)]
        [InlineData(new int[] { 1, 3, 6, 7, 9 }, true)]
        [InlineData(new int[] { 2, 4, 6, 9, 10, 9 }, true)]
        public void IsSafeUsingProblemDampener(int[] levels, bool isSafe)
        {
            Report report = new([.. levels]);

            Assert.Equal(isSafe, report.IsSafeUsingProblemDampener);
        }

        [Fact]
        public void IsSafeUsingProblemDampener_LastItemIsTheProblem_ReturnsTrue()
        {
            List<int> levels = [2, 4, 6, 9, 10, 9];

            Report report = new(levels);

            Assert.True(report.IsSafeUsingProblemDampener);
        }
    }
}
