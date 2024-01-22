using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    public class Person
    {
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }

        public Person (int personId, string firstName, string lastName, string favoriteColour, int age,  bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"{personId}: {fullName}'s favorite colour is: {favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            favoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {personId} \n" +
                   $"FirstName: {firstName} \n" +
                   $"LastName: {lastName} \n" +
                   $"FavoriteColour: {favoriteColour} \n" +
                   $"Age: {age} \n" +
                   $"IsWorking: {isWorking}";
        }
    }
}
