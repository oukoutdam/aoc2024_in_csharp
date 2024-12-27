class Solver
{
    public List<List<int>> updateOrder { get; } = [];

    private void ruleParser(string line)
    {
        int[] numberPair = line.Split('|').Select(int.Parse).ToArray();

        if (updateOrder.Count == 0)
        {
            List<int> currentPair = [];
            currentPair.Add(numberPair[0]);
            currentPair.Add(numberPair[1]);

            updateOrder.Add(currentPair);
        }

        foreach (List<int> ruleList in updateOrder)
        {
            if (ruleList.Contains(numberPair[0]))
            {

            }
        }


    }

    public Solver(string inputPath)
    {
        try
        {
            foreach (var line in File.ReadLines(inputPath))
            {
                if (line.Contains('|'))
                {
                    ruleParser(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }

    }
}