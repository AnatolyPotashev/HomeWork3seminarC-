// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
double max = Convert.ToInt32(Console.ReadLine());
double i = 1;

for (i = 1; i <= max; i++)
{
    Console.Write(Math.Pow(i, 3)+" ");
}
