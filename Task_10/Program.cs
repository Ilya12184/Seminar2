/*Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. */

int GetSecondNumber(int number)
{
    int SecondNumber = number / 10 % 10;
    return SecondNumber;
}

int number = 785;
int SecondNumber = GetSecondNumber(number);

Console.WriteLine(SecondNumber);