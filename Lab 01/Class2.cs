using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    public class Relation
    {
        public enum RelationshipType
        {
            Sister, Brother, Mother, Father
        }

        public RelationshipType relationshipType { get; set; }  

        public Relation(RelationshipType relationshipType)
        {
            this.relationshipType = relationshipType;
        }
        public void ShowRelationship(string person1Name, string person2Name)
        {
            Console.WriteLine($"Relationship between {person1Name} and {person2Name} is: {relationshipType}hood");
        }
    }
}
