namespace Library
{
    public abstract class Visitor
    {
        public int Sum { get; protected set; }

        public abstract void Visit(Node node);

        public abstract void Visit(Person person);
    }
}