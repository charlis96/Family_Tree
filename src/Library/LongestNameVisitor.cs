namespace Library
{
    public class LongestNameVisitor : Visitor
    {
        public override void Visit(Node node)
        {
            node.Person.Accept(this);
            foreach (Node children in node)
            {
                children.Accept(this);
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