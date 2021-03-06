﻿using System;
using ConsoleApp1.Classes;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Events {
    public class EquippedEventHandlerArgs : EventArgs {

        public IItem Item;

        public EquippedEventHandlerArgs(IItem item) {
            Item = item;
        }
    }

    public class DamagedEventHandlerArgs : EventArgs {
        public int DamageTaken { get; }
        public Enemy Attacker { get; }

        public DamagedEventHandlerArgs(int damageTaken, Enemy attacker) {
            Attacker = attacker;
            DamageTaken = damageTaken;
        }
    }

}