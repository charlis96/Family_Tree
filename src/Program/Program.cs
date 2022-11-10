using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, "José", 80);
            Node n2 = new Node(2, "Juan", 50);
            Node n3 = new Node(3, "Agustina", 48);
            Node n4 = new Node(4, "Andrés", 16);
            Node n5 = new Node(5, "Ronaldinho", 25);
            Node n6 = new Node(6, "Arnold", 24);
            Node n7 = new Node(7, "Bruno", 21);
            Node n8 = new Node(8, "Natalia", 20);
            Node n9 = new Node(9, "Ronaldinho Jr.", 22);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);
            n2.AddChildren(n6);

            n3.AddChildren(n7);
            n3.AddChildren(n8);
            n3.AddChildren(n9);

            // Aquí visito el árbol.

            AgeCalculatorVisitor AgeCalculatorVisitor = new AgeCalculatorVisitor();
            n1.Accept(AgeCalculatorVisitor);
            Console.WriteLine($"La suma de las edades es de {AgeCalculatorVisitor.Sum} años.");

            OldestPersonVisitor OldestPersonVisitor = new OldestPersonVisitor();
            n1.Accept(OldestPersonVisitor);
            Console.WriteLine($"El hijo más grande se llama {OldestPersonVisitor.OldestPerson.Name}.");

            LongestNameVisitor LongestNameVisitor = new LongestNameVisitor();
            n1.Accept(LongestNameVisitor);
            Console.WriteLine($"El nombre más largo es {LongestNameVisitor.LongestNamePerson.Name}.");
        }
    }
}