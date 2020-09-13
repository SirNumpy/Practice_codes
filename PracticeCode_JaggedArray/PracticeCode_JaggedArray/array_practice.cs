using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracticeCode_JaggedArray
{
    class array_practice
    {
        public void arraylist() 
        {
            ArrayList student = new ArrayList();
            student.Add("prabhat");
            student.Add(19);
            student.Add("male");
            student.Add(2000);
            foreach(object obj in student)
            {
                if (obj is string)
                {
                    Console.WriteLine(obj);
                }else if(obj is int)
                {
                    int number = (int)obj;
                    Console.WriteLine(number);
                }
            }


        }
    }
}
