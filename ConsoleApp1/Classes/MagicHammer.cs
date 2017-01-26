using ConsoleApp1.Delegates;
using ConsoleApp1.Events;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Classes {
    public class MagicHammer : IItem, IEquipeable {
        public string Name { get; set; }

        public MagicHammer(string name) {
            Name = name;
        }

        public void Equip() {
            OnEquipped(new EquippedEventHandlerArgs(this));
        }

        public event EquippedEventHandler Equipped;

        protected virtual void OnEquipped(EquippedEventHandlerArgs args) {
            Equipped?.Invoke(this, args);
        }

        public override string ToString() {
            return $"{Name}";
        }

    }
}