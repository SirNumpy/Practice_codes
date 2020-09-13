using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphic
{
    class BMW:Cars
    {
        private string brand = "m50";
        public BMW(string colour, int hp, string brand):base(colour,hp) 
        {
            this.brand = brand;
        }
        public new void showInfo()
        {
            Console.WriteLine("brand "+ brand+" the colour is " + colour + "hp is " + hp);
        }
        public override void repair()
        {
            Console.WriteLine("your BMW "+ brand+ " is repaired ");
        }
    }
  
}
