using System;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=> Use PersonCollection:");

            PersonCollection myPeople = new PersonCollection();
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople[4] = new Person("Maggie", "Simpson", 2);

            for (int i = 0; i < myPeople.CountPerson; i++)
            {
                Console.WriteLine("Person number: {0}", i);
                Console.WriteLine("Name: {0} {1}",
                  myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Age: {0}", myPeople[i].Age);
                Console.WriteLine();
            }

            Console.WriteLine("=> Use PersonDictionary:");
            PersonDictionary personDictionary = new();
            personDictionary["Homer"] = new Person("Homer", "Simpson", 40);
            personDictionary.AddPerson("Marge", new Person("Marge", "Simpson", 38));

            Console.WriteLine("personDictionary[\"Homer\"]: " +
                personDictionary["Homer"]);
            Console.WriteLine("personDictionary[\"Marge\"]: " +
                personDictionary["Marge"]);
        }
    }
}
