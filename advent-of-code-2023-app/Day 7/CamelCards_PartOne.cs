﻿
using advent_of_code.Day_7;

namespace advent_of_code
{
    public static class CamelCards_PartOne
    {
        public static void Run()
        {
            string? line;
            List<string> text = [];

            try
            {
                StreamReader sr = new("D:\\Git\\advent-of-code-2023\\advent-of-code\\Day 7\\input-camel-cards.txt");
                line = sr.ReadLine();

                while (line != null)
                {
                    text.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();

                InputFormatter formatter = new([.. text]);

                Hand[] hands = formatter.Hands;
                Game game = new(hands, false);

                Console.WriteLine($"Total winnings: {game.TotalWinnings}");
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
