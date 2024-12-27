# Advent of Code 2024
Going to do this using 'C#'.
## How to Add a New Project
1. Create the project
```
dotnet new console -n <NameOfProject>
```
2. Add the project to the solution file
```
dotnet sln add <NameOfProject>/<NameOfProject>.csproj
```
3. Run specific project
```
# run this if path to input.txt is relative to Program.cs
cd <NameOfProject>
dotnet run

# run below if the path of input.txt is set from solution root
# dotnet run --project <NameOfProject>
```
