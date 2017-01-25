﻿using System;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {
    public class Sword : IItem, IDamageable {

        public Sword(string name, int durability) {
            Name = name;
            Durability = durability;
            InitialDurability = durability;
        }

        private int InitialDurability { get; }

        public string Name { get; set; }
        public void Equip() {
            Console.WriteLine($"{Name} a été équipé");
        }

        public int Durability { get; set; }

        public void TakeDamage(int amount) {
            Durability -= amount;
            Console.WriteLine($"{Name} a pris {amount} de dégâts ({Durability}/{InitialDurability}");
        }

        public override string ToString() {
            return $"{Name} ({Durability}/{InitialDurability})";
        }
    }
}