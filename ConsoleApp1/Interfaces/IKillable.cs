using ConsoleApp1.Classes;
using ConsoleApp1.Delegates;

namespace ConsoleApp1.Interfaces {
    public interface IKillable {
        event DeathEventHandler Death;
        void TakeDamage(int amount, Enemy from);
        int Health { get; set; }
        bool Dead { get; set; }
    }
}