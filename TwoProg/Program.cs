// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double x1, y1, z1, x2, y2, z2;
double distance = 0;

Console.WriteLine("Первая точка (Х):");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Первая точка (Y):"); 
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Первая точка (Z):");
z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Вторая точка (Х):");
x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Вторая точка (Y):");
y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Вторая точка (Z):");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между двумя точками в 3D равно: {distance}");

// Задание показалось тяжёлым, гуглил, но вроде разобрался. С практикой закреплю!