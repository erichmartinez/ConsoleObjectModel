using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObjectModel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel1> people1 = new List<PersonModel1>();
            people1.Add(new PersonModel1 { ID = 1, Name = "Parent 1" });
            people1.Add(new PersonModel1 { ID = 2, Name = "Parent 2" });
            people1.Add(new PersonModel1 { ID = 3, Name = "Parent 3" });

            foreach (PersonModel1 p1 in people1)
            {
                p1.people2 = new List<PersonModel2>();
                p1.people2.Add(new PersonModel2 { ID = 1, Person1ID = p1.ID, Name = $"Parent {p1.ID} Child" });
                p1.people2.Add(new PersonModel2 { ID = 2, Person1ID = p1.ID, Name = $"Parent {p1.ID} Child" });
                p1.people2.Add(new PersonModel2 { ID = 3, Person1ID = p1.ID, Name = $"Parent {p1.ID} Child" });
            }

            foreach (PersonModel1 p1 in people1)
            {
                Console.WriteLine($"{p1.Name} ({p1.people2.Count})");

                foreach (PersonModel2 p2 in p1.people2)
                {
                    Console.WriteLine($"{p2.Name}-{p2.ID}");
                }
            }

            Console.ReadLine();
        }
    }
}
