using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using ConsoleApp1.Classes;
using ConsoleApp1.Events;
using static System.Console;
using static ConsoleApp1.Utils;

namespace ConsoleApp1
{
    internal class Program {

        #region Variables


        #endregion

        private static void Main(string[] args) {
            var character = CreateCharacter();
            character.Death += CharacterOnDeath;
            character.Damaged += CharacterOnDamaged;


            while (true) {
                Thread.Sleep(1000);
                var chance = new Random().Next(0, 100);
                if (chance <= 23) {
                    FindWeapon();
                }
                else if(chance <=30) {
                    MeetEnemy(character);
                }
            }
        }

        private static void CharacterOnDamaged(object sender, DamagedEventHandlerArgs args) {
            WriteLine(args.Attacker.Name + " vous a attaque et a inflige " + args.DamageTaken + " degats");
        }

        private static void MeetEnemy(Person character) {
            var enemy = new Enemy(new Random().Next(1,5));
            enemy.MakeDamage(character);
            WriteLine(character.Health);

        }

        private static void CharacterOnDeath(object sender, EventArgs args) {
            var character = sender as Person;
            WriteLine(character?.FullName + " est mort");
            if (AskYesNoQuestion("Recommencer la partie ?")) {
                var fileName = Assembly.GetExecutingAssembly().Location;
                if (fileName != null) System.Diagnostics.Process.Start(fileName);
                Environment.Exit(0);
            } else Environment.Exit(0);
        }

        #region Parts

        private static Person CreateCharacter() {
            PrintHeader("Création du personnage");
            var answer = AskQuestion("Veuillez choisir un nom et un prénom pour votre personnage");
            var firstname = answer.Split()[0];
            var lastname = answer.Split()[1];
            var age = AskIntQuestion("Choisissez votre âge");
            return new Person(age, firstname, lastname);
        }

        private static void FindWeapon() {
            var names = new Dictionary<string, string[]>() {
                {"Swords", new[] {"Excalibur", "Blazefury", "Forsaken Longsword", "Deathraze", "Fireguard Skewer", "Nightfall, Executioner of Stealth"}},
                {"Axes", new[] {"Valkyrie", "Stalker", "Faithful Ivory Axe", "Orenmir", "Soul Reaper"}}
            };

            var rnd = new Random();
            var chance = rnd.Next(0, 100);
            if (chance <= 33) {
                var name = names["Swords"][rnd.Next(0, names["Swords"].Length)];
                var sword = new Sword(name, rnd.Next(20, 200));
                sword.Equipped += SwordOnEquipped;
            } else if (chance <= 66) {
                var name = names["Axes"][rnd.Next(0, names["Axes"].Length)];
            } else if (chance >= 67) {

            }
        }


        #endregion

        #region Events

        private static void SwordOnDamaged(object sender, DamagedEventHandlerArgs args) {
            var sword = sender as Sword;
            WriteLine($"{sword?.Name} a pris {args.DamageTaken} de dégâts ({sword?.Durability}/{sword?.InitialDurability})");

        }

        private static void MagicHammerOnEquipped(object sender, EquippedEventHandlerArgs args) {
            WriteLine($"{args.Item.ToString()} a ete equipe");
        }

        private static void AxeOnEquipped(object sender, EquippedEventHandlerArgs args) {
            WriteLine($"{args.Item.ToString()} a ete equipe");
        }

        private static void SwordOnEquipped(object sender, EquippedEventHandlerArgs args) {
            WriteLine($"{args.Item.ToString()} a ete equipe");
        }

        #endregion

    }
}
