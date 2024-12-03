using System.Text.RegularExpressions;

namespace advent_of_code_2024_app.Day3
{
    public class MemoryFormatter()
    {
        public static List<int[]> FindNumbers(string input)
        {
            string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";
            MatchCollection matches = Regex.Matches(input, pattern);

            List<int[]> pairs = [];
            foreach (Match match in matches)
            {
                if (match.Groups.Count == 3) // Ensure there are 2 capture groups
                {
                    string firstNumber = match.Groups[1].Value;
                    string secondNumber = match.Groups[2].Value;
                    Console.WriteLine($"Pair: ({firstNumber}, {secondNumber})");

                    if (int.TryParse(firstNumber, out int number1) && int.TryParse(secondNumber, out int number2))
                        pairs.Add([number1, number2]);
                }
            }

            return pairs;
        }

        public static List<int[]> FindEnabledNumbers(string input)
        {
            string pattern = @"don't\(\)(.*?)do\(\)";

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                return FindEnabledNumbers(Regex.Replace(input, pattern, ""));
            }

            return FindNumbers(input);
        }
    }
}
