/*Напишите программу, которая принимает на вход цифру,обозначающую день недели,
и проверяет, является ли этот день выходным.*/

int GetNumber(int number)
{
    if (number<6 & number>0)
    {
        Console.WriteLine("Будни");
    }
    else if (number>5 & number<8)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Формат числа задан не верно, введите от 1 до 7");
    }
    int Num = number;
    return Num;
}
System.Console.Write("Введите значение дня недели: ");
int number = int.Parse(Console.ReadLine()!);
int Num = GetNumber(number);
