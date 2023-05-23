using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "James", "John", "Robert", "Michael", "William", "Charles", "Joseph", "Thomas" };

        var namesEndingWithS = from name in names
            where name.EndsWith("s")
            select name;

        Console.WriteLine("Имена, заканчивающиеся на 'S':");
        foreach (var name in namesEndingWithS)
        {
            Console.WriteLine(name);
        }

        int maxLength = names.Max(name => name.Length);

        Console.WriteLine("Размер самого длинного имени: " + maxLength);
    }
}