﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONSOLE
{
  public  class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;

        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, Number in Stock ={2}", 

                Name, Description, NumberInStock);

        }

    }
}
