namespace Library
{
    public abstract class Visitor
    {
        public abstract void Visit(AddAge age);

        public abstract void Visit(Node node);

        public abstract void Visit(Person person);
    }
}