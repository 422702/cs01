// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача№2");
Console.WriteLine("Введите число");
string input=Console.ReadLine(  );
int number1= int.Parse(input);
Console.WriteLine("Введите число");
input=Console.ReadLine();
int number2= int.Parse(input);
if(number1>number2)Console.WriteLine($"Чило{number1} больше"); else Console.WriteLine($"Чило{number2} больше");