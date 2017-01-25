using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public bool IsMajeur()
        {
            return Age > 18;
        }

        public int? LengthName()
        {
            return FirstName?.Length + LastName?.Length;
        }

        public override string ToString()
        {
            return $"{FullName} a {Age} ans.\nIl { (IsMajeur() ? "est" : "n'est pas") } majeur";
        }
    }
}
