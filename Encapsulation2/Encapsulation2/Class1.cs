using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation2
{
   public class Class1
    {

        private int price=20000;

        private int production_year=2022;

        


      public int Price
        {
            get { return price; }
            set
            {
                if (value > 20000)
                {
                    price = 20000;
                }
                else
                {
                    price = value;
                }
            }
        }

        public int Production_year
        {
            get { return production_year; }
        }
  }
}
