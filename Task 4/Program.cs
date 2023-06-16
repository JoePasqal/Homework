// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string? num1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? num2 = Console.ReadLine();
Console.WriteLine("Введите третье число");
string? num3 = Console.ReadLine();
int Num1 = Convert.ToInt32(num1);
int Num2 = Convert.ToInt32(num2);
int Num3 = Convert.ToInt32(num3);
int max = Num1;
if (Num2 > max) max = Num2;
if (Num3 > max) max = Num3;
Console.WriteLine($"{max} - максимальное число");