namespace Library
{
    public class AgeCalculatorVisitor : Visitor
    {
        public int Sum { get; protected set; } = 0;

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
            this.Sum += person.Age;
        }
    }
}