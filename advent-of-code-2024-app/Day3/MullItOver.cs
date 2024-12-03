using advent_of_code_2024_app.Day2;

namespace advent_of_code_2024_app.Day3
{
    public static class MullItOver
    {
        public static void Run()
        {
            string? line;
            try
            {
                StreamReader sr = new("D:\\Git\\advent-of-code\\advent-of-code-2024-app\\Day2\\input-red-nosed-reports.txt");
                line = sr.ReadLine();

                List<Report> reports = [];

                while (line != null)
                {
                    Console.WriteLine(line);
                    if (line.Equals(string.Empty)) continue;

                    string[] numbers = line.Split(' ').Where(value => value != string.Empty).ToArray();

                    List<int> levels = [];

                    foreach (string number in numbers)
                    {
                        if (int.TryParse(number, out int level)) levels.Add(level);
                    }

                    Report report = new(levels);
                    reports.Add(report);
                    Console.WriteLine(report.IsSafe);

                    line = sr.ReadLine();
                }

                sr.Close();

                int result = reports.Count(report => report.IsSafeUsingProblemDampener);
                Console.WriteLine($"{result} reports are safe");

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                throw;
            }
            finally
            {
                Console.WriteLine("Executing final block.");
            }
        }
    }
}
