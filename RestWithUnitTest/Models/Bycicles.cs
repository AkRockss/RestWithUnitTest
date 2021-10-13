using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RestWithUnitTest.Models
{
    public class Bycicles
    {

        public int Id { get; set;}
        public string Name { get; set; }

        public int Price { get; set; }

        public Bycicles()
        {
                
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
