class Program
{
    public static void Main()
    {
        string filePath = "./input.txt";

        try
        {
            int safeCount = 0;
            foreach (var line in File.ReadLines(filePath))
            {
                int[] intLine = line.Split(' ').Select(int.Parse).ToArray();

                int diff = intLine[1] - intLine[0];
                int diffAbs = Math.Abs(diff);
                if (diffAbs < 1 || diffAbs > 3) continue;

                bool isSafe = true;

                for (int i = 2; i < intLine.Length; i++)
                {
                    int currDiff = intLine[i] - intLine[i - 1];
                    int currDiffAbs = Math.Abs(currDiff);

                    if (currDiffAbs < 1 || currDiffAbs > 3 || currDiff * diff <= 0)
                    {
                        isSafe = false;
                        break;
                    }
                }

                if (isSafe) safeCount++;
            }

            Console.WriteLine(safeCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

    }
}