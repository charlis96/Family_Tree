using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1, "José", 80);
            Node n2 = new Node(2, "María", 78);
            Node n3 = new Node(3, "Pedro", 81);
            Node n4 = new Node(4, "Josefina", 76);
            Node n5 = new Node(5, "Juan", 50);
            Node n6 = new Node(6, "Agustina", 48);
            Node n7 = new Node(7, "Bruno", 23);
            Node n8 = new Node(8, "Natalia", 20);
            Node n9 = new Node(9, "Ronaldinho", 17);

            n1.AddChildren(n5);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n4.AddChildren(n6);

            n5.AddChildren(n7);
            n5.AddChildren(n8);
            n5.AddChildren(n9);
            n6.AddChildren(n7);
            n6.AddChildren(n8);
            n6.AddChildren(n9);

            // visitar el árbol aquí
            Visitor AgeCalculator = new AgeCalculatorVisitor();
            n1.Accept(AgeCalculator);
            Console.WriteLine($"La suma de las edades es de {AgeCalculator.Sum} años.");

            Visitor OldestPerson = new OldestPersonVisitor();
            n1.Accept(OldestPerson);
            Console.WriteLine($"El hijo más grande se llama {OldestPerson.OldestPersonName}.");
        }
    }
}