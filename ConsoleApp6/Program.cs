using System;
using System.IO;

do
{
    const string fileName = "meFile.txt";
    Console.WriteLine("Smotret istoriu - 1, novue dichislenia - 2");
    int f = int.Parse(Console.ReadLine());
    if (f == 0)
    {
        if (File.Exists(fileName))
            Console.WriteLine(File.ReadAllText(fileName));
        else
            Console.WriteLine("File pustoi");
    }
    else
    {
        Console.WriteLine("sum = 1, rasdelenie = 2, delenie = 3, umnozenie = 4.");
        int vibor = int.Parse(Console.ReadLine());
        Console.WriteLine("Vvedite pervoe chislo");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Vvedite vtoroe chislo");
        int b = int.Parse(Console.ReadLine());
        if (vibor == 1)
        {
            int res = a + b;
            Console.WriteLine($"{a}+{b} = {res}\n");
            File.AppendAllText(fileName, $"{a}+{b} = {res}\n");
        }
        else if (vibor == 2)
        {
            int res = a - b;
            Console.WriteLine($"{a}-{b} = {res}\n");
            File.AppendAllText(fileName, $"{a}-{b} = {res}\n");
        }
        else if (vibor == 3)
        {
            int res = a / b;
            Console.WriteLine($"{a}-{b} = {res}\n");
            File.AppendAllText(fileName, $"{a}-{b} = {res}\n");
        }
        else
        {
            int res = a * b;
            Console.WriteLine($"{a}-{b} = {res}\n");
            File.AppendAllText(fileName, $"{a}-{b} = {res}\n");
        }
    }
} while (true);