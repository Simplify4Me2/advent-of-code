﻿namespace advent_of_code_2024_app.Day1
{
    public static class HistorianHysteria
    {
        public static void Run()
        {
            string? line;
            try
            {
                List<int> leftList = [];
                List<int> rightList = [];

                StreamReader sr = new("D:\\Git\\advent-of-code\\advent-of-code-2024-app\\Day1\\input-historian-hysteria.txt");
                line = sr.ReadLine();
                while (line != null && line != string.Empty)
                {
                    Console.WriteLine(line);
                    if (line.Equals(string.Empty)) continue;

                    string[] numbers = line.Split(' ').Where(value => value != string.Empty).ToArray();

                    if (numbers.Length != 2)
                        throw new ArgumentException("2 lists expected");

                    if (int.TryParse(numbers.First(), out int leftNumber)) leftList.Add(leftNumber);
                    if (int.TryParse(numbers.Last(), out int rightNumber)) rightList.Add(rightNumber);

                    line = sr.ReadLine() ?? string.Empty;
                }

                sr.Close();

                if (leftList.Count != rightList.Count)
                    throw new ArgumentException("List are not the same length");

                ListSimilarizer similarizer = new(leftList, rightList);

                Console.WriteLine($"Sum: {similarizer.CalculateSum()}");
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
