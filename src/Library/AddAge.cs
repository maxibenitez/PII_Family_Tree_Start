namespace Library
{
    public class AddAge : IVisitor
    {
        public int Ages{ get; set;}

        public AddAge()
        {
            this.Ages = 0;
        }

        public void Visit(Node node)
        {
            this.Ages += node.Age.Age;

            foreach(Node nodo in node.Children)
            {
                nodo.Accept(this);
            }
        }
    }
}