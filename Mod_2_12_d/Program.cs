using System;

class Program
{
    static void Main()
    {
        Console.Write("d. Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("d. Введите значение b (b > a): ");
        int b = int.Parse(Console.ReadLine());

        if (b > a)
        {
            Console.WriteLine($"Все целые числа от {a} до {b}:");
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Значение b должно быть больше a.");
        }
    }
}
