namespace Library
{
    public class LongestNameVisitor : Visitor
    {
        public Person LongestNamePerson { get; set; } = null;

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
            if (this.LongestNamePerson == null)
            {
                this.LongestNamePerson = person;
            }
            else if (person.Name.Length > this.LongestNamePerson.Name.Length)
            {
                this.LongestNamePerson = person;
            }
        }
    }
}