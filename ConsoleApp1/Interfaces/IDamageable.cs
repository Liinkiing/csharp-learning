namespace ConsoleApp1.Interfaces
{
    public interface IDamageable
    {
        int Durability { get; set; }
        void TakeDamage(int amount);
    }
}