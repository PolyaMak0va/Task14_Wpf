using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_Wpf
{
    public enum ProductCategories
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public ProductCategories ProductCategory { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
