﻿using advent_of_code.Day_4;

namespace advent_of_code_tests.Day_4
{
    public class ScratchcardCollectionTest
    {
        private readonly Scratchcard[] _data =
        [
            new Scratchcard([41, 48, 83, 86, 17], [83, 86, 6, 31, 17, 9, 48, 53]),
            new Scratchcard([13, 32, 20, 16, 61], [61, 30, 68, 82, 17, 32, 24, 19]),
            new Scratchcard([1, 21, 53, 59, 44], [69, 82, 63, 72, 16, 21, 14, 1]),
            new Scratchcard([41, 92, 73, 84, 69], [59, 84, 76, 51, 58, 5, 54, 83]),
            new Scratchcard([87, 83, 26, 28, 32], [88, 30, 70, 12, 93, 22, 82, 36]),
            new Scratchcard([31, 18, 13, 56, 72], [74, 77, 10, 23, 35, 67, 36, 11])
         ];

        [Fact]
        public void Total_ReturnsSumOfAllOriginalAndCopiedScratchcards()
        {

            ScratchcardCollection collection = new(_data);

            Assert.Equal(30, collection.Total);
        }

        [Fact]
        public void Total_ReturnsSumOfFirstAndSecond()
        {
            ScratchcardCollection collection = new([
                new Scratchcard([41, 48, 83, 86, 17], [83, 86, 6, 31, 17, 9, 48, 53]),
                new Scratchcard([13, 32, 20, 16, 61], [61, 30, 68, 82, 17, 32, 24, 19]),
                new Scratchcard([1, 21, 53, 59, 44], [69, 82, 63, 72, 16, 21, 14, 1]),
                new Scratchcard([41, 92, 73, 84, 69], [59, 84, 76, 51, 58, 5, 54, 83])
            ]);
            Assert.Equal(15, collection.Total);
        }
    }
}
