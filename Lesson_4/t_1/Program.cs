// Задача 1: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNum(int num)
{
    int all_Sum = 0;
    for(int i = 1; i <= num; i++)
    {
        all_Sum += i;
    }
    return all_Sum;
}

Console.WriteLine(SumNum(7));
Console.WriteLine(SumNum(4));