// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int SumNum()
{
    int Num = int.Parse(Console.ReadLine());
    int sum = 0;
    while (Num > 0)
    {
        sum += Num % 10;
        Num /= 10;
    }
    return sum;
}

Console.WriteLine(SumNum());
