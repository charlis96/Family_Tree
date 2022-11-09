namespace Library
{
    public class OldestPersonVisitor : Visitor
    {
        public override void Visit(Node node)
        {
            foreach (Node children in node)
            {
                children.Accept(this);
                if (node.Children.Count == 0)
                {
                    node.Person.Accept(this);
                }
            }
        }

        public override void Visit(Person person)
        {
            if (person.Age > this.OldestAge)
            {
                this.OldestAge = person.Age;
                this.OldestPersonName = person.Name;
            }
        }
    }
}