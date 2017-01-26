using ConsoleApp1.Delegates;

namespace ConsoleApp1.Interfaces
{
    public interface IDamageable
    {
        int Durability { get; set; }
        event DamagedEventHandler Damaged;
        void TakeDamage(int amount);
    }
}