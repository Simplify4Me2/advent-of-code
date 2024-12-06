using advent_of_code_2024_app.Day4;

namespace advent_of_code_2024_tests.Day4
{
    public class PuzzleInputTest
    {
        [Fact]
        public void GetHorizontalLines()
        {
            PuzzleInput input = new();

            input.Add("..X...");
            input.Add(".SAMX.");
            input.Add(".A..A.");
            input.Add("XMAS.S");
            input.Add(".X....");

            var result = input.HorizontalLines;

            Assert.Equal(5, result.Count);
            Assert.Equal("..X...", result[0]);
            Assert.Equal(".SAMX.", result[1]);
            Assert.Equal(".A..A.", result[2]);
            Assert.Equal("XMAS.S", result[3]);
            Assert.Equal(".X....", result[4]);
        }

        [Fact]
        public void GetVerticalLines()
        {
            PuzzleInput input = new();

            input.Add("..X...");
            input.Add(".SAMX.");
            input.Add(".A..A.");
            input.Add("XMAS.S");
            input.Add(".X....");

            var result = input.VerticalLines;

            Assert.Equal(6, result.Count);
            Assert.Equal("...X.", result[0]);
            Assert.Equal(".SAMX", result[1]);
            Assert.Equal("XA.A.", result[2]);
            Assert.Equal(".M.S.", result[3]);
            Assert.Equal(".XA..", result[4]);
            Assert.Equal("...S.", result[5]);
        }

        [Fact]
        public void GetDiagonalLines()
        {
            PuzzleInput input = new();

            input.Add("..X...");
            input.Add(".SAMX.");
            input.Add(".A..A.");
            input.Add("XMAS.S");
            input.Add(".X....");

            var result = input.DiagonalLines;

            Assert.Equal(20, result.Count);
            Assert.Contains(".", result);
            Assert.Contains("XX", result);
            Assert.Contains(".M.", result);
            Assert.Contains(".AA.", result);
            Assert.Contains(".S.S.", result);
            Assert.Contains(".A...", result);
            Assert.Contains("XMAS", result);
            Assert.Contains(".X.", result);
            Assert.Contains("..", result);
            Assert.Contains("XS.", result);
            Assert.Contains(".AAX", result);
            Assert.Contains(".AS.", result);
        }

        [Fact]
        public void FindSingle_XMasOccurrences()
        {
            PuzzleInput input = new();

            input.Add("M.S");
            input.Add(".A.");
            input.Add("M.S");

            Assert.Equal(1, input.XMasOccurences);
        }

        [Fact]
        public void FindMultiple_XMasOccurrences()
        {
            PuzzleInput input = new();

            input.Add("MMMSXXMASM");
            input.Add("MSAMXMSMSA");
            input.Add("AMXSXMAAMM");
            input.Add("MSAMASMSMX");
            input.Add("XMASAMXAMM");
            input.Add("XXAMMXXAMA");
            input.Add("SMSMSASXSS");
            input.Add("SAXAMASAAA");
            input.Add("MAMMMXMMMM");
            input.Add("MXMXAXMASX");

            Assert.Equal(9, input.XMasOccurences);
        }
    }
}
