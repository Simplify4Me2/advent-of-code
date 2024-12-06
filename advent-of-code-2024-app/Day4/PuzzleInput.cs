using System.Text;

namespace advent_of_code_2024_app.Day4
{
    public class PuzzleInput
    {
        private readonly List<string> _horizontalLines = [];
        private readonly WordSearch search = new();
        private int Height => _horizontalLines.Count;
        private int Width => _horizontalLines[0]?.Length ?? 0;

        public List<string> HorizontalLines => _horizontalLines;
        public List<string> VerticalLines => GetVerticalLines();
        public List<string> DiagonalLines => GetDiagonalLines();

        public int Occurrences => FindOccurrences();

        public int XMasOccurences => FindXMasOccurences();

        public void Add(string line)
        {
            HorizontalLines.Add(line);
        }

        public int FindXMasOccurences()
        {
            int rows = Height;
            int occurrences = 0;

            for (int row = 0; row < rows; row++)
            {
                int cols = Width;
                for (int col = 0; col < cols; col++)
                {
                    if (_horizontalLines[row][col] == 'A' && HasXMas(row, col))
                        occurrences++;
                }
            }

            return occurrences;
        }

        private bool HasXMas(int row, int col)
        {
            if (row == 0 || col == 0) return false;
            if (row == Height - 1 || col == Width - 1) return false;

            char[,] grid = new char[3, 3];

            grid[0,0] = _horizontalLines[row - 1][col - 1];
            grid[0,1] = _horizontalLines[row - 1][col];
            grid[0,2] = _horizontalLines[row - 1][col + 1];

            grid[1, 0] = _horizontalLines[row][col - 1];
            grid[1, 1] = _horizontalLines[row][col];
            grid[1, 2] = _horizontalLines[row][col + 1];

            grid[2, 0] = _horizontalLines[row + 1][col - 1];
            grid[2, 1] = _horizontalLines[row + 1][col];
            grid[2, 2] = _horizontalLines[row + 1][col + 1];

            //if ()

            //grid.ToString().Count(c => c == 'M');

            if (grid[0,0] == 'M' && grid[2,2] == 'S')
            {
                if (grid[2, 0] == 'M' && grid[0, 2] == 'S')
                    return true;

                if (grid[2, 0] == 'S' && grid[0, 2] == 'M')
                    return true;
            }

            if (grid[0, 0] == 'S' && grid[2, 2] == 'M')
            {
                if (grid[2, 0] == 'M' && grid[0, 2] == 'S')
                    return true;

                if (grid[2, 0] == 'S' && grid[0, 2] == 'M')
                    return true;
            }

            return false;
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

        private int FindOccurrences()
        {
            int occurrences = 0;

            HorizontalLines.ForEach(line => occurrences += search.Find(line));
            VerticalLines.ForEach(line => occurrences += search.Find(line));
            DiagonalLines.ForEach(line => occurrences += search.Find(line));

            return occurrences;
        }
    }
}