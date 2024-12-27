class Program {
	public static void Main(){
		string filePath = "./input.txt";

		List<int> left = [];
		List<int> right = [];

		try {
			string[] lines = File.ReadAllLines(filePath);

			foreach(var line in lines){
				string[] values = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

				if (values.Length == 2){
					left.Add(int.Parse(values[0]));
					right.Add(int.Parse(values[1]));
				}
			}

		} catch (Exception ex){
			Console.WriteLine($"Error: {ex.Message}");
		}

		Console.WriteLine(left.Count);

		

	}
}
