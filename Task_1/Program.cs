/*
 * Задача 19:
 * Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 */
int Reverse(int number)
{
    int numberReverse = 0;
    while (number > 0)
    {
        numberReverse = numberReverse * 10 + number % 10;
        number /= 10;
    }
    return numberReverse;
}

while (true)
{
    try
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int aReverse = Reverse(a);
        if (a == aReverse) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
    catch
    {

        Console.WriteLine("вы ошиблись это не число ");

    }
}