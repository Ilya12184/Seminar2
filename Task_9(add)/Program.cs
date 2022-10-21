/*Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.*/

int GetNumber(int number)
{
    if (number % 7 == 0 & number % 23 == 0)
    {
        Console.WriteLine("Заданное число кратно 7 и 23");
    }
    else
    {
        Console.WriteLine("Заданное число не кратно 7 и 23 одновременно");
    }
    int Num = number;
    return Num;
}

System.Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int Num = GetNumber(number);