using ConsoleApp1.Classes;
using ConsoleApp1.Delegates;

namespace ConsoleApp1.Interfaces
{
    public interface IEquipeable
    {
        void Equip();
        event EquippedEventHandler Equipped;
    }
}