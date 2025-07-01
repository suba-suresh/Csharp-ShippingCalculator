// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()

    {
        Console.Write("Enter the number of items to ship: ");
        int totalitems = Convert.ToInt32(Console.ReadLine());


        int itemsPerBox = 5;
        decimal costPerBox = 4.75m;
        decimal costPerLeftover =   1.50m;  

        int Fullboxes = totalitems / itemsPerBox;   // integer division to find full boxes
        int Leftovers = totalitems % itemsPerBox;   // modulus to find leftover items


        // Calculate total cost
        decimal totalCost = (Fullboxes * costPerBox) + (Leftovers > 0 ? costPerLeftover : 0);

        // Output using string interpolation
        Console.WriteLine($"You need {Fullboxes} full box(es) and {Leftovers} leftover item(s).");

        Console.WriteLine($"Total shipping cost: ${totalCost}");

    }

}
