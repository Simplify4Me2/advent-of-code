namespace advent_of_code_2024_app.Day4
{
    public static class CeresSearch
    {
        public static void Run()
        {
            string? line;
            try
            {
                StreamReader sr = new("D:\\Git\\advent-of-code\\advent-of-code-2024-app\\Day4\\input-ceres-search.txt");
                line = sr.ReadLine();

                PuzzleInput input = new();

                while (line != null)
                {
                    Console.WriteLine(line);
                    input.Add(line);

                    line = sr.ReadLine();
                }

                sr.Close();

                Console.WriteLine($"Occurences: {input.XMasOccurences}");

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
