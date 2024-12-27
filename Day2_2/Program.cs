class Solver
{
    public string InputPath { get; }

    public Solver(string inputPath)
    {
        InputPath = inputPath;
    }
    public int Solve()
    {
        int safeCount = 0;

        try
        {
            foreach (var line in File.ReadLines(InputPath))
            {
                List<int> numbers = line.Split(' ').Select(int.Parse).ToList();
                int endIndex = CheckSafety(numbers);
                if (endIndex == numbers.Count)
                {
                    safeCount++;
                }
                else if (endIndex < numbers.Count - 2)
                {
                    List<int> numbersRemoveFirst = numbers.ToList();
                    numbersRemoveFirst.RemoveAt(endIndex);
                    List<int> numbersRemoveEnd = numbers.ToList();
                    numbersRemoveEnd.RemoveAt(endIndex + 1);

                    if (CheckSafety(numbersRemoveFirst) == numbers.Count - 1 || CheckSafety(numbersRemoveEnd) == numbers.Count - 1)
                    {
                        safeCount++;
                    }
                }
                else
                {
                    List<int> numbersRemoveFirst = numbers.ToList();
                    numbersRemoveFirst.RemoveAt(endIndex);

                    if (CheckSafety(numbersRemoveFirst) == numbers.Count - 1)
                    {
                        safeCount++;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

        return safeCount;
    }

    private int CheckSafety(List<int> numbers)
    {
        int difference = numbers[1] - numbers[0];
        int absDifference = Math.Abs(difference);
        if (absDifference < 1 || absDifference > 3) return 0;

        for (int i = 2; i < numbers.Count; i++)
        {
            int currentDifference = numbers[i] - numbers[i - 1];
            int absCurrentDifference = Math.Abs(currentDifference);

            if (absCurrentDifference < 1 || absCurrentDifference > 3 || currentDifference * difference < 0) return i;
        }

        return numbers.Count;
    }
}

class Program
{
    public static void Main()
    {
        string inputPath = "./input.txt";
        Solver slv = new(inputPath);
        Console.WriteLine(slv.Solve());
    }
}