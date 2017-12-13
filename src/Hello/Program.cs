namespace Hello {
    using System;

    class Person {
        public int Age { set; get; }
        public String Name { set; get; }
    }

    class Program {
        string unusedVariable;
        static string nullVariable;
        static void Main(string[] args) {

            Console.WriteLine(nullVariable);

            string noVar = "Value A";

            Person p = new Person();
            p.Name = "Mahmoud";
            p.Age = 25;
        }
    }
}