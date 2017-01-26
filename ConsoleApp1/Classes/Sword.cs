using System;
using ConsoleApp1.Delegates;
using ConsoleApp1.Events;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {



    public class Sword : IItem, IDamageable, IEquipeable {

        public event DamagedEventHandler Damaged;

        public event EquippedEventHandler Equipped;


        public Sword(string name, int durability) {
            Name = name;
            Durability = durability;
            InitialDurability = durability;
        }

        public int InitialDurability { get; }

        public string Name { get; set; }


        public int Durability { get; set; }

        public void TakeDamage(int amount) {
            Durability -= amount;
            OnDamaged(new DamagedEventHandlerArgs(amount, null));
        }

        public override string ToString() {
            return $"{Name} ({Durability}/{InitialDurability})";
        }


        public void Equip(Person person) {
            person.Items.Add(this);
            OnEquipped(new EquippedEventHandlerArgs(this));
        }

        protected virtual void OnDamaged(DamagedEventHandlerArgs args) {
            Damaged?.Invoke(this, args);
        }

        protected virtual void OnEquipped(EquippedEventHandlerArgs args) {
            Equipped?.Invoke(this, args);
        }

        public void Equip() {
            throw new NotImplementedException();
        }
    }

}