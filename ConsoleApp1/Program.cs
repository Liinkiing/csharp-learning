using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Classes;
using ConsoleApp1.Events;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person(19, "Omar", "JBARA");
            var sword = new Sword("Excalibur", 100);
            var axe = new Axe("Hache du titan", 200);
            var magicHammer = new MagicHammer("Marteau de Thor");

            sword.Equipped += SwordOnEquipped;
            sword.Damaged += SwordOnDamaged;
            axe.Equipped += AxeOnEquipped;
            magicHammer.Equipped += MagicHammerOnEquipped;

            magicHammer.Equip();
            sword.Equip();
            sword.TakeDamage(12);
            axe.Equip();
//            Console.WriteLine(person.ToString());
//            Console.WriteLine("===============================");
//            sword.Equip();
//            Console.WriteLine(person.ToString());
//
//            Console.WriteLine("===============================");
//            sword.TakeDamage(20);
//            Console.WriteLine(person.ToString());
//
//            Console.WriteLine("===============================");
//            axe.Equip();
//            axe.TakeDamage(72);
//            Console.WriteLine(person.ToString());

            Console.ReadLine();


        }

        private static void SwordOnDamaged(object sender, DamagedEventHandlerArgs args) {
            var sword = sender as Sword;
            Console.WriteLine($"{sword?.Name} a pris {args.DamageTaken} de dégâts ({sword?.Durability}/{sword?.InitialDurability})");

        }

        private static void MagicHammerOnEquipped(object sender, EquippedEventHandlerArgs args) {
            Console.WriteLine($"{args.Item.ToString()} a ete equipe");
        }

        private static void AxeOnEquipped(object sender, EquippedEventHandlerArgs args) {
            Console.WriteLine($"{args.Item.ToString()} a ete equipe");
        }

        private static void SwordOnEquipped(object sender, EquippedEventHandlerArgs args) {
            Console.WriteLine($"{args.Item.ToString()} a ete equipe");
        }
    }
}
