using System.Text;

namespace advent_of_code_2024_app.Day4
{
    public class PuzzleInput
    {
        private readonly List<string> _horizontalLines = [];

        public List<string> HorizontalLines => _horizontalLines;
        public List<string> VerticalLines => GetVerticalLines();
        public List<string> DiagonalLines => GetDiagonalLines();

        public void Add(string line)
        {
            HorizontalLines.Add(line);
        }

        private List<string> GetVerticalLines()
        {
            int column = 0;
            List<string> lines = [];
            int length = _horizontalLines[0].Length;

            while (column < length)
            {
                StringBuilder sb = new();
                for (int i = 0; i < _horizontalLines.Count; i++)
                {
                    sb.Append(_horizontalLines[i][column]);
                }
                lines.Add(sb.ToString());
                column++;
            }

            return lines;
        }

        private List<string> GetDiagonalLines()
        {
            List<string> diagonals = [];

            diagonals.AddRange(GetMainDiagonalLines());
            diagonals.AddRange(GetAntiDiagonalLines());

            return diagonals;
        }

        private List<string> GetMainDiagonalLines()
        {
            int rows = _horizontalLines.Count;
            int cols = _horizontalLines[0].Length;
            List<string> diagonals = [];

            // Iterate over diagonals identified by (col - row)
            for (int d = -rows + 1; d < cols; d++)
            {
                List<char> diagonal = [];
                for (int row = 0; row < rows; row++)
                {
                    int col = row + d;
                    if (col >= 0 && col < cols)
                    {
                        diagonal.Add(_horizontalLines[row][col]);
                    }
                }
                if (diagonal.Count > 0)
                {
                    diagonals.Add(new string([.. diagonal]));
                }
            }

            return diagonals;
        }

        private List<string> GetAntiDiagonalLines()
        {
            int rows = _horizontalLines.Count;
            int cols = _horizontalLines[0].Length;
            List<string> diagonals = [];

            // Iterate over diagonals identified by (row + col)
            for (int d = 0; d < rows + cols - 1; d++)
            {
                List<char> diagonal = [];
                for (int row = 0; row < rows; row++)
                {
                    int col = d - row;
                    if (col >= 0 && col < cols)
                    {
                        diagonal.Add(_horizontalLines[row][col]);
                    }
                }
                if (diagonal.Count > 0)
                {
                    diagonals.Add(new string([.. diagonal]));
                }
            }

            return diagonals;
        }
    }
}