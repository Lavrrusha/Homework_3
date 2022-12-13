/*
 * Задача 21:
 * Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
*/
double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt( (x1 - x2) * (x1 - x2)
                     + (y1 - y2) * (y1 - y2)
                     + (z1 - z2) * (z1 - z2));
}
while (true)
{
    try
    {
        Console.Write("Введите число x1: ");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число y1: ");
        int y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число z1: ");
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число x2: ");
        int x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число y2: ");
        int y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число z2: ");
        int z2 = Convert.ToInt32(Console.ReadLine());
    double distance = Distance(x1,y1,z1,x2,y2,z2);
    Console.WriteLine($"Расстояние: {distance:N2}");
    }
    catch
    {

        Console.WriteLine("вы ошиблись это не число ");

    }
} 
