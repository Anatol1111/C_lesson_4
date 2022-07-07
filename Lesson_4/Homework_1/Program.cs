// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
void ADegreeB()
{
    int A = int.Parse(Console.ReadLine());
    int B = int.Parse(Console.ReadLine());
    int DegreeNum = 1;
    for (int i = 1; i <= B; i++)
    {
        DegreeNum *= A;
    }
    Console.WriteLine(DegreeNum);
}

ADegreeB();