Console.Clear();
Console.WriteLine("Введите строку");
string element = Console.ReadLine();
string[] array = element.Split(' '); ;
var result = new string[array.Length];
var count = 0;
foreach (var value in array)
{

    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, count));