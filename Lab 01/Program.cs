using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            person2.DisplayPersonInfo();

            Console.WriteLine(person3.ToString());

            person1.ChangeFavoriteColour();

            person1.DisplayPersonInfo();

            Console.WriteLine($"{person4.firstName} {person4.lastName}'s Age in 10 years is: {person4.GetAgeInTenYears()}");

            Relation relation1 = new Relation(Relation.RelationshipType.Sister);
            Relation relation2 = new Relation(Relation.RelationshipType.Brother);

            relation1.ShowRelationship(person2.firstName, person4.firstName);
            relation2.ShowRelationship(person1.firstName, person3.firstName);

            List<Person> personList = new List<Person> { person1, person2, person3, person4 };

            int totalAge = 0;
            foreach (Person person in personList)
            {
                totalAge += person.age;
            }

            double averageAge = (double) totalAge / personList.Count;
            Console.WriteLine($"Average age is {averageAge}");

            Person youngest = personList[0];
            Person oldest = personList[0];

            foreach(Person person in personList)
            {
                if (person.age < youngest.age)
                {
                    youngest = person;
                }

                if(person.age > oldest.age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"The youngest person is: {youngest.firstName}");
            Console.WriteLine($"The oldest person is: {oldest.firstName}");

            foreach(Person person in personList)
            {
                if (person.firstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());
                }
            }

            foreach(Person person in personList)
            {
                if (person.favoriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
