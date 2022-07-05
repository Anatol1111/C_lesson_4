// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int Num = int.Parse(Console.ReadLine());
int sum = 0;
while (Num > 0)
{
    sum = sum + Num % 10;
    Num /= 10;
}
Console.WriteLine(sum);