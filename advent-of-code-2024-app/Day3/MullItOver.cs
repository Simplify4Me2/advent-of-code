
namespace advent_of_code_2024_app.Day3
{
    public static class MullItOver
    {
        public static void Run()
        {
            string? line;
            try
            {
                StreamReader sr = new("D:\\Git\\advent-of-code\\advent-of-code-2024-app\\Day3\\input-mull-it-over.txt");
                line = sr.ReadLine();

                int result = 0;

                while (line != null)
                {
                    List <int[]> instructions = MemoryFormatter.FindEnabledNumbers(line);

                    foreach (int[] pair in instructions)
                    {
                        result += pair.First() * pair.Last();
                    }

                    line = sr.ReadLine();
                }

                sr.Close();

                Console.WriteLine($"Result: {result}");

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
