using System.Text.RegularExpressions;

namespace advent_of_code_2024_app.Day4
{
    public class WordSearch
    {
        private readonly string pattern = @"XMAS";

        public int Find(string line)
        {
            int matches = 0;

            matches += Regex.Matches(line, pattern).Count;

            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            string invertedLine = new(charArray);

            matches += Regex.Matches(invertedLine, pattern).Count;

            return matches;
        }
    }
}
