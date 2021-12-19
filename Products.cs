using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CONSOLE
{
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int NumberInStock { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId = {0}, ProductName = {1}, NumberInStock = {2}, CategoryId = {3}",
                ProductId, ProductName, NumberInStock, CategoryId);
        }
        }
    }
