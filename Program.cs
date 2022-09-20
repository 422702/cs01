// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача№2");
Console.WriteLine("Введите число");
string input=Console.ReadLine(  );
int number1= int.Parse(input);
Console.WriteLine("Введите число");
input=Console.ReadLine();
int number2= int.Parse(input);
if(number1>number2)Console.WriteLine($"Чило{number1} больше"); else Console.WriteLine($"Чило{number2} больше");

Console.WriteLine("Задача№4");
Console.WriteLine("Введите число");
input=Console.ReadLine(  );
number1= int.Parse(input);
Console.WriteLine("Введите число");
input=Console.ReadLine();
number2= int.Parse(input);
Console.WriteLine("Введите число");
input=Console.ReadLine();
int number3= int.Parse(input);
if(number1>number2&&number1>number3)Console.WriteLine($"Чило{number1} больше");
if(number2>number1&&number2>number3)Console.WriteLine($"Чило{number2} больше");
if(number3>number2&&number3>number1)Console.WriteLine($"Чило{number3} больше");

Console.WriteLine("Задача№6");
Console.WriteLine("Введите число");
input=Console.ReadLine(  );
number1= int.Parse(input);
if((number1 % 2)==0)Console.WriteLine("число чётное"); else Console.WriteLine("число не чётное");