// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int EnterNUmber(string str)
{
    Console.Write(str);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Clear();
Console.WriteLine("Введите кординату точки A");
int nuberX1 = EnterNUmber("Введите X: ");
int nuberY1 = EnterNUmber("Введите Y: ");
int nuberZ1 = EnterNUmber("Введите Z: ");
Console.WriteLine("Введите кординату точки B");
int nuberX2 = EnterNUmber("Введите X: ");
int nuberY2 = EnterNUmber("Введите Y: ");
int nuberZ2 = EnterNUmber("Введите Z: ");

double distace = Math.Sqrt(Math.Pow(nuberX1 - nuberX2, 2) + Math.Pow(nuberY1 - nuberY2, 2) + Math.Pow(nuberZ1 - nuberZ2, 2));

Console.WriteLine("Расстояние между точкой А и B = " + distace);