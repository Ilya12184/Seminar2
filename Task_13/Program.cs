/*Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/

int GetThreeNumber(int number)
{
    if (99<number & number<1000) 
    {
        number = number % 10;
    }

    if (number>1000)
    {
        while (number>1000)
        {
            number = number / 10;
        }
        number = number % 10;
    }
    else
    {
        Console.WriteLine("Третья цифра отсутствует");
    } 

    int ThreeNumber = number;
    return ThreeNumber;
}

int number = 856239;
int ThreeNumber = GetThreeNumber(number);

Console.WriteLine(ThreeNumber);

