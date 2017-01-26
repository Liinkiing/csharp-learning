using System;
using System.Collections.Generic;
using ConsoleApp1.Delegates;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {
    public class Enemy : IKillable{
        public event DeathEventHandler Death;

        public int Tier { get; set; }

        public string Name { get; set; }

        private Dictionary<int, string[]> _names;


        public Enemy(int tier) {
            Tier = tier;
            InitNames();
            Name = _names[Tier][new Random().Next(0, _names[Tier].Length)];
        }

        private void InitNames() {
            _names = new Dictionary<int, string[]>() {
                {TiersType.Weak, new [] {"Crazechill", "Evilslash", "Flarecraze", "Icevault", "Loveshiver", "Stenchrock"}},
                {TiersType.Common, new [] {"Crazechill", "Evilslash", "Flarecraze", "Icevault", "Loveshiver", "Stenchrock"}},
                {TiersType.Good, new [] {"Crazechill", "Evilslash", "Flarecraze", "Icevault", "Loveshiver", "Stenchrock"}},
                {TiersType.Fantastic, new [] {"Crazechill", "Evilslash", "Flarecraze", "Icevault", "Loveshiver", "Stenchrock"}},
                {TiersType.Rare, new [] {"Crazechill", "Evilslash", "Flarecraze", "Icevault", "Loveshiver", "Stenchrock"}},
            };
        }

        public void TakeDamage(int amount) {
            Health -= amount;
            OnDeath();
        }

        public void MakeDamage(Person character) {
            character.TakeDamage(new Random().Next((int)Tier, (int)Tier * 4), this);

        }

        public void TakeDamage(int amount, Enemy @from) {
            throw new NotImplementedException();
        }

        public int Health { get; set; }
        public bool Dead { get; set; }

        protected virtual void OnDeath() {
            Death?.Invoke(this, EventArgs.Empty);
        }
    }
}