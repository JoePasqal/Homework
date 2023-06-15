// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? num2 = Console.ReadLine();
int Num1 = Convert.ToInt32(num1);
int Num2 = Convert.ToInt32(num2);
if(Num1 > Num2)
{
    Console.WriteLine($"{num1} больше, чем {num2}");
}
else
{
Console.WriteLine($"{num2} больше, чем {num1}");
}