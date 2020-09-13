using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphic
{
    class Cars
    {

        public string colour { get; set; }
        public int hp;
        protected CarIDInfo carIdInfo = new CarIDInfo();
        public void SetCarIDInfo(string owner,int idNo)
        {
            carIdInfo.IdInfo = idNo;
            carIdInfo.Owner = owner;
        }
        public void GetIdNo()
        {
            Console.WriteLine("id no. of this vehicle is "+carIdInfo.IdInfo+" owner is "+carIdInfo.Owner);
        }


        public Cars(string colour , int hp)
        {
            this.colour = colour;
            this.hp = hp;
        }
        public   void showInfo()
        {
            Console.WriteLine("the colour is "+colour+"hp is "+hp);
        }
        public  virtual void repair()
        {
            Console.WriteLine("your car is repaired ");
        }
        protected void check()
        {
            Console.WriteLine("just checking");
        }
    }
}
