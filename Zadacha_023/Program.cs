// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Напишите число");
int number = int.Parse(Console.ReadLine());
int index = 1;
while (index < number)
{
    double cube = Math.Pow(index, 3);
    Console.Write(cube + ",");
    index++;
}
Console.Write(Math.Pow(number, 3));