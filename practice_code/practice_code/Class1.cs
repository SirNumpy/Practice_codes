using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace practice_code
{
    class Class1
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int FrontSurfaceArea
        {
            get
            {
                return Length * Breadth;
                
            }
        }
    }
}
