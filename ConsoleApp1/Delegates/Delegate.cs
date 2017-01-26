using System;
using ConsoleApp1.Events;

namespace ConsoleApp1.Delegates {

    public delegate void DamagedEventHandler(object sender, DamagedEventHandlerArgs  e);


    public delegate void EquippedEventHandler(object sender, EquippedEventHandlerArgs args);
}