Console.WriteLine("Hello C# ");
Console.WriteLine("Name :CengizMert Özgüven ");
Console.WriteLine("Department: Computer Engineering");
Console.WriteLine("Year:2 ");
Console.WriteLine(DateTime.Now);
Console.WriteLine("Enter temperature in Celsius");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine(fahrenheit);