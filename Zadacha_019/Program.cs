// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int InputNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ReversNumber(int value)
{
    int count = 0;
    int number = 0;
    while(count < 5)
    {
        int ostatok = value % 10;
        number = number * 10 + ostatok;
        value = value / 10;
        count++;
    }
    return number;
}

int numberA = InputNumber("Введите пятизначное число ");
int numberB = ReversNumber(numberA);

if (9999 < numberA && numberA < 100000)
{
    if(numberA == numberB)
        Console.WriteLine($"Число {numberA} палиндром");
    else
        Console.WriteLine($"Число {numberA} не палиндром");
}
else 
    Console.WriteLine($"Число {numberA} не пятизначное");