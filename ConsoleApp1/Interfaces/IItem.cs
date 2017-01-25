namespace ConsoleApp1.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        void Equip();
        string ToString();
    }
}