// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int count = 1;
int sum = 0;
while(count <= A)
{
    sum = sum + count;
    count++; 
}
Console.WriteLine(sum);
