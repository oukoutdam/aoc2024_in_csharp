
string filePath = "./input.txt";
List<int> left = [];
List<int> right = [];

try
{
    string[] lines = File.ReadAllLines(filePath);
    foreach (string line in lines)
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

left.Sort();
right.Sort();

int sum = 0;
for (int i = 0; i < left.Count; i++)
{
    var val = left[i] - right[i];
    sum += (val > 0) ? val : -val;
}

Console.WriteLine(sum);
