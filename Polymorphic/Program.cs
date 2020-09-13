using System;

namespace Polymorphic
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW car1 = new BMW("green", 100, "m50");
            car1.showInfo();
            car1.repair();
            Cars car2 = new BMW("GREEN", 1000, "M39");
            car2.showInfo();
            car2.repair();
            car1.SetCarIDInfo("prabhat", 1234);
            car1.GetIdNo();
            
            
        }
    }
}
