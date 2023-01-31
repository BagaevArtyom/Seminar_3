// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число:");
int count = int.Parse(Console.ReadLine()!);
int number = 1;
while (number <= count)
    {
    Console.Write($"{Math.Pow(number, 3)}");
    if (number != count) Console.Write(", ");
    number++;
    }

    