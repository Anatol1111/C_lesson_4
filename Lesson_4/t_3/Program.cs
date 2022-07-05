// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

int PNum(int num)
{
    int all_Sum = 1;
    for(int i = 1; i <= num; i++)
    {
        all_Sum *= i;
    }
    return all_Sum;
}

Console.WriteLine(PNum(5));
Console.WriteLine(PNum(4));