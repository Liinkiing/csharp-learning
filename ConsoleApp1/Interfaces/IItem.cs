using System;
using ConsoleApp1.Events;

namespace ConsoleApp1.Interfaces
{
    public interface IItem
    {
        string Name { get; set; }
        string ToString();

    }
}