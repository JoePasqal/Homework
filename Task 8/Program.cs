// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число, я покажу магию четных чисел");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Да будет МАГИЯ!");
for (int i=2; i<=number; i+=2)
{
    Console.Write(i);
}