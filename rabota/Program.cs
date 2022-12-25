Console.Clear();
Console.WriteLine("Введите строку");
string element = Console.ReadLine();
string[] array = element.Split(' '); ;
var result = new string[array.Length];
var count = 0;