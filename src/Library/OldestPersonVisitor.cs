namespace Library
{
    public class OldestPersonVisitor : Visitor
    {
        public Person OldestPerson { get; set; } = null;

        public override void Visit(Node node)
        {
            if (node.Children.Count == 0)
            {
                node.Person.Accept(this);
            }
            foreach (Node children in node)
            {
                children.Accept(this);
            }
        }

        public override void Visit(Person person)
        {
            if (this.OldestPerson == null)
            {
                this.OldestPerson = person;
            }
            else if (person.Age > this.OldestPerson.Age)
            {
                this.OldestPerson = person;
            }
        }
    }
}