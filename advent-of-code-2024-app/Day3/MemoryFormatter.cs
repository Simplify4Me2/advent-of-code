using System.Text.RegularExpressions;

namespace advent_of_code_2024_app.Day3
{
    public class MemoryFormatter()
    {
        public bool IsEnabled { get; internal set; } = true;

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

        public List<int[]> FindEnabledNumbers(string input)
        {
            string pattern = @"do\(\)|don't\(\)|mul\((\d{1,3}),(\d{1,3})\)";
            List<int[]> pairs = [];

            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                if (match.Value == "do()")
                    IsEnabled = true;
                else if (match.Value == "don't()")
                    IsEnabled = false;
                else
                {
                    if (IsEnabled && match.Groups.Count == 3)
                    {
                        string firstNumber = match.Groups[1].Value;
                        string secondNumber = match.Groups[2].Value;
                        Console.WriteLine($"Pair: ({firstNumber}, {secondNumber})");

                        if (int.TryParse(firstNumber, out int number1) && int.TryParse(secondNumber, out int number2))
                            pairs.Add([number1, number2]);
                    }
                }

                //return FindEnabledNumbers(Regex.Replace(input, pattern, ""));
            }

            //if (Regex.Match(input, @"don't\(\)(.*)").Success)
            //    return FindEnabledNumbers(Regex.Replace(input, @"don't\(\)(.*)", ""));

            return pairs;
        }
    }
}
