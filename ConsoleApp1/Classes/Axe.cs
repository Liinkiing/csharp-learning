using System;
using ConsoleApp1.Delegates;
using ConsoleApp1.Events;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {
    public class Axe : IItem, IDamageable, IEquipeable {

        public Axe(string name, int durability) {
            Name = name;
            Durability = durability;
            InitialDurability = durability;
        }

        private int InitialDurability { get; }
        public string Name { get; set; }

        public int Durability { get; set; }
        public event DamagedEventHandler Damaged;

        public void TakeDamage(int amount) {
            Durability -= amount;
            Console.WriteLine($"{Name} a pris {amount} de dégâts ({Durability}/{InitialDurability}");
        }

        public override string ToString() {
            return $"{Name} ({Durability}/{InitialDurability})";
        }

        public void Equip() {
           OnEquipped(new EquippedEventHandlerArgs(this));
        }

        public event EquippedEventHandler Equipped;

        protected virtual void OnEquipped(EquippedEventHandlerArgs args) {
            Equipped?.Invoke(this, args);
        }
    }
}