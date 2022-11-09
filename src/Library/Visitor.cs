namespace Library
{
    public abstract class Visitor
    {
        public int Sum { get; protected set; } = 0;
        public int OldestAge { get; set; } = 0;
        public string OldestPersonName { get; set; }
        public abstract void Visit(Node node);
        public abstract void Visit(Person person);
    }
}