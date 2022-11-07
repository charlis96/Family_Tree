using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node : IEnumerable
    {
        private int number;
        private List<Node> children = new List<Node>();
        public Person Person { get; }

        public int Number
        {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, string name, int age)
        {
            this.number = number;
            this.Person = new Person(name, age);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public IEnumerator GetEnumerator()
        {
            return this.Children.GetEnumerator();
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}