﻿using advent_of_code_2024_app.Day1;

namespace advent_of_code_2024_tests.Day1
{
    public class ListComparerTest
    {
        [Fact]
        public void CalculateSum_ReturnsSumOfDistances()
        {
            var leftList = new List<int> { 3, 4, 2, 1, 3, 3 };
            var rightList = new List<int>() { 4, 3, 5, 3, 9, 3 };

            ListComparer comparer = new(leftList, rightList);

            Assert.Equal(11, comparer.CalculateSum());
        }
    }
}
