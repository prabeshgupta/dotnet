using System;

//Namespace is used to work with multiple classes
namespace app
{
    class Person
    {
        //Properties
        public int age;
    }

    class ReferenceType
    {
        static void Main(string[] args)
        {
            //Object
            Person p1 = new Person();
            p1.age = 5;
            Console.WriteLine(p1.age);

            //Passing Reference
            reference(p1);
            Console.WriteLine(p1.age);
        }

        static void reference(Person p)
        {
            p.age *= p.age;
            Console.WriteLine(p.age);
        }
    }
}