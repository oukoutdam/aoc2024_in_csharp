// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string fileName = "data.json";
string dataFilePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
Console.WriteLine(dataFilePath);