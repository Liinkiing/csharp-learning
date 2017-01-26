using System.Collections.Generic;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1
{
    public class Person {

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<IItem> Items { get; set; }

        public string FullName => FirstName + " " + LastName;

        public Person(int age, string firstName, string lastName) {
            Items = new List<IItem>();
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }


        public bool IsMajeur() {
            return Age > 18;
        }

        public int? LengthName() {
            return FirstName?.Length + LastName?.Length;
        }

        public override string ToString() {
            string itemsStr = "";
            if (Items.Count > 0) {
                foreach (var item in Items) {
                    itemsStr += $"\n - {item.ToString()}";
                }
            }
            return $"{FullName} a {Age} ans. \n Il { (IsMajeur() ? "est" : "n'est pas") } majeur \n La personne a {Items.Count} item(s) dans son inventaire \n {itemsStr}";
        }

    }
}
