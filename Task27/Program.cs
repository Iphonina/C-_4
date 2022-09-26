// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int X = Convert.ToInt32(Console.ReadLine());

int Sum = 0;
int count = 0;
while (count <= X)
{
    Sum = Sum + X%10;
    X/= 10;
    count++;
}

Console.WriteLine($"Сумма цифр в данном числе равна {Sum}");