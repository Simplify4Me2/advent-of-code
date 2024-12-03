namespace advent_of_code_2024_app.Day2
{
    public class Report(List<int> levels)
    {
        public bool IsSafe => VerifySafety(levels);
        public bool IsSafeUsingProblemDampener => VerifySafetyUsingProblemDampener(levels);

        private static bool VerifySafety(List<int> levels)
        {
            bool isIncreasing = levels[0] < levels[1];

            for (int i = 0; i < levels.Count - 1; i++)
            { 
                int currentLevel = levels[i];
                int nextLevel = levels[i + 1];

                if (currentLevel == nextLevel)
                    return false;
                if (Math.Abs(currentLevel - nextLevel) > 3)
                    return false;

                if (isIncreasing && currentLevel > nextLevel) 
                    return false;
                if (!isIncreasing && currentLevel < nextLevel) 
                    return false;
            }

            return true;
        }

        private static bool VerifySafetyUsingProblemDampener(List<int> levels)
        {
            bool isSafe = VerifySafety(levels);
            if (isSafe) return true;

            for (int i = 0; i < levels.Count; i++)
            {
                var newList = new List<int>(levels);
                newList.RemoveAt(i);
                if (VerifySafety(newList)) return true;
            }

            return false;
        }
    }
}
