class Program
{
	public static void Main()
	{
		string filePath = "./input.txt";

		List<int> left = [];
		List<int> right = [];
		Dictionary<int, int> rightCount = [];

		try
		{
			string[] lines = File.ReadAllLines(filePath);

			foreach (var line in lines)
			{
				string[] values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				if (values.Length == 2)
				{
					left.Add(int.Parse(values[0]));
					right.Add(int.Parse(values[1]));
				}
			}

		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error: {ex.Message}");
		}

		// save the count for each number in right list
		foreach (var number in right)
		{
			if (rightCount.ContainsKey(number))
			{
				rightCount[number] += 1;
			}
			else
			{
				rightCount.Add(number, 1);
			}
		}

		int sum = 0;
		foreach (var number in left)
		{
			if (rightCount.ContainsKey(number))
			{
				sum += number * rightCount[number];
			}
		}

		Console.WriteLine(sum);


		// foreach (KeyValuePair<int, int> element in rightCount)
		// {
		// 	Console.WriteLine($"key: {element.Key}, value: {element.Value}");
		// }

	}
}
