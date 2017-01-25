using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person(19, "Omar", "JBARA");
            var sword = new Sword("Excalibur", 100);
            var axe = new Axe("Hache du titan", 200);

            Console.WriteLine(person.ToString());

            Console.WriteLine("===============================");
            person.Equip(sword);
            Console.WriteLine(person.ToString());

            Console.WriteLine("===============================");
            sword.TakeDamage(20);
            Console.WriteLine(person.ToString());

            Console.WriteLine("===============================");
            person.Equip(axe);
            axe.TakeDamage(72);
            Console.WriteLine(person.ToString());

            Console.ReadLine();
            

        }
    }
}
