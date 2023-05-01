// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

if (number/100 != 0) {
    int number2 = number/100;
    System.Console.WriteLine($"третья цифра числа {number} - {number2%10}");}
else {
    System.Console.WriteLine("третьей цифры нет");
}