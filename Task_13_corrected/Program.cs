/*Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/

int GetThreeNumber(int number)
{
    if (number<100)
    {
        Console.WriteLine("Третья цифра отсутствует");
    }
    else
    {
        while(number>999)
        {
            number = number/10;
        }
        number = number % 10;
    }
    int ThreeNumber = number;
    return ThreeNumber;
}
int number = 7798325;
int ThreeNumber = GetThreeNumber(number);
Console.WriteLine(ThreeNumber);