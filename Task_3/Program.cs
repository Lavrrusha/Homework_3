/*
 * Задача 23:
 * Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
 */
while (true)
{
    try
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            int i = 1;
            while (i <= number)
            {
                Console.Write(Math.Pow(i,3));
                if (i != number)
                    Console.Write(",");
                i++;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Число меньше 1");
        }
    }
    catch
    {
        Console.WriteLine("вы ошиблись это не число ");
    }
}