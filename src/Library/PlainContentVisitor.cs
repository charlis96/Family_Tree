namespace Library
{
    public class PlainContentVisitor : Visitor
    {
        public override void Visit(Node node)
        {
            this.Sum = 0;
            foreach (Node children in node)
            {
                children.Accept(this);
            }
            

            this.ContentBuilder.Append($"Total: ${sale.Total}");
        }

        public override void Visit(Person person)
        {
            this.ContentBuilder.Append($"{item.Quantity} de ");
            item.Product.Accept(this);
        }
    }
}