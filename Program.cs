using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a 4-digit number: ");
        int num = int.Parse(Console.ReadLine());

        HashSet<int> results = new HashSet<int>();
        while (num >= 1000 && num <= 9999 && !results.Contains(num))
        {
            results.Add(num);
            int numAsc = int.Parse(string.Concat(num.ToString().OrderBy(x => x)));
            int numDesc = int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
            int previous = num;
            num = numDesc - numAsc;
            Console.WriteLine($"{previous} -> {numAsc} -> {numDesc} -> {num}");
        }
    }
}
