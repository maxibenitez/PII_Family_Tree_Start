using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Person("Raúl Benítez", 96));

            Node n2 = new Node(new Person("Jorge Benítez", 78));
            Node n3 = new Node(new Person("Roberto Benítez", 74));
            Node n4 = new Node(new Person("Carlos Benítez", 69));

            Node n5 = new Node(new Person("Luis Benítez", 59));
            Node n6 = new Node(new Person("Francisco Benítez", 55));
            Node n7 = new Node(new Person("Hugo Benítez", 52));

            Node n8 = new Node(new Person("Maximiliano Benítez", 30));

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n2.AddChildren(n4);

            n2.AddChildren(n5);
            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n3.AddChildren(n8);

            AddAge age = new AddAge();
            n1.Accept(age);
            int addAges = age.Ages;

            Console.WriteLine(addAges);

        }
    }
}
