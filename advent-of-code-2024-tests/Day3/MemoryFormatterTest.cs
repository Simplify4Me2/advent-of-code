using advent_of_code_2024_app.Day3;

namespace advent_of_code_2024_tests.Day3
{
    public class MemoryFormatterTest
    {
        [Fact]
        public void FindNumbers_FindsASingleInstruction()
        {
            string input = "mul(8,5)";

            Assert.Contains([8, 5], MemoryFormatter.FindNumbers(input));
        }

        [Fact]
        public void FindNumbers_FindsMultipleInstructions()
        {
            string input = "xmul(2,4)%&mul[3,7]!@^do_not_mul(5,5)+mul(32,64]then(mul(11,8)mul(8,5))";
            
            var result = MemoryFormatter.FindNumbers(input);

            Assert.Contains([2, 4], result);
            Assert.Contains([5, 5], result);
            Assert.Contains([11, 8], result);
            Assert.Contains([8, 5], result);
        }

        [Fact]
        public void FindEnabledNumbers_FindsMultipleInstructions()
        {
            string input = "xmul(2,4)&mul[3,7]!^don't()_mul(5,5)+mul(32,64](mul(11,8)undo()?mul(8,5))\r\n";

            MemoryFormatter formatter = new();

            var result = formatter.FindEnabledNumbers(input);

            Assert.Contains([2, 4], result);
            Assert.DoesNotContain([5, 5], result);
            Assert.DoesNotContain([11, 8], result);
            Assert.Contains([8, 5], result);
        }
    }
}
