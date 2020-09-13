using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphic
{
    class Audi:Cars
    {
        private string brand = "a13";
        public Audi(string colour,int hp,string brand):base(colour,hp)
        {
            this.brand = brand;
        }
        public void showInfo()
        {
            Console.WriteLine("brand " + brand + " the colour is " + colour + "hp is " + hp);
        }
        public void repair()
        {
            Console.WriteLine("your audi " + brand + " is repaired ");
        }
    }
}
