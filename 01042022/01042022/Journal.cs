using System;
using System.Collections.Generic;
using System.Text;

namespace _01042022
{
    class Journal:Product
    {
        public string Company { get; set; }


        public override void GetInfo()
        {
            Console.WriteLine($"Company: {Company}  Name: {Name}  Price: {Price   }");
        }
    }
}
