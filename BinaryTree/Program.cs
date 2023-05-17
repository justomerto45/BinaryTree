using BinaryTree.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // erstellt eine liste von zahlen
            List<int> numbers = new List<int> { 46, 27, 64, 9, 35, 51, 75, 4, 24, 47, 68, 82, 30, 90, 39 };


            
            // erstellt einen binärbaum aus der liste von zahlen
            Node root = Node.CreateTree(numbers, 46);

            // fügt eine zahl in den binärbaum
            Node.AddNode(root, 49);

            // gibt den min und max wert im baum aus
            Console.WriteLine("Minimum: " + root.FindMin());
            // oder wegen List<>()
            //Console.WriteLine("Minimum: " + numbers.Min());

            Console.WriteLine("Maximum: " + root.FindMax());
            // oder wegen List<>()
            //Console.WriteLine("Maximum: " + numbers.Max());


            // gibt die zahlen im baum in auf und aufsteigender reihenfolge aus
            Console.Write("Aufsteigend: ");
            root.PrintAscending();
            Console.WriteLine();

            //oder wegen List<>()
            //Console.Write("In Order: ");
            //var orderedNumbers = numbers.OrderBy(x => x);
            //foreach (int number in orderedNumbers)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();

            // gibt die zahlen im baum in auf und absteigender reihenfolge aus
            Console.Write("Absteigend: ");
            root.PrintDescending();
            Console.WriteLine();
            //oder wegen List<>()
            //Console.Write("In Reverse Order: ");
            //var reverseOrderedNumbers = numbers.OrderByDescending(x => x);
            //foreach (int number in reverseOrderedNumbers)
            //{ 
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();
        }
    }
}
