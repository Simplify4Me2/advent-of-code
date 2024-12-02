namespace advent_of_code_2024_app.Day2
{
    public class Report(List<int> levels)
    {
        public bool IsSafe => VerifySafety();

        private bool VerifySafety()
        {
            bool isIncreasing = levels[0] < levels[1];

            for (int i = 0; i < levels.Count - 2; i++)
            { 
                int currentLevel = levels[i];
                int nextLevel = levels[i + 1];

                if (currentLevel == nextLevel)
                    return false;
                if (currentLevel < nextLevel && !isIncreasing)
                    return false;
                if (currentLevel > nextLevel && isIncreasing)
                    return false;
                if (Math.Abs(currentLevel - nextLevel) > 3)
                    return false;
            }

            return true;
        }
    }
}
