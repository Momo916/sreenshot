using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumTakesScreenshot
{
    public class Supplier
    {
        public string Name { get; private set; }
        public int SupplierID { get; private set; }

        public Supplier(string name, int supplierID)
        {
            Name = name;
            SupplierID = supplierID;
        }
        public static List<Supplier> GetSampleSupplier()
        {
            return new List<Supplier>
            {
                new Supplier(name:"Beijing",supplierID:1),
                new Supplier(name:"Wuxi",supplierID:2),
                new Supplier(name:"Guangzhou",supplierID:4),
                new Supplier(name:"Shanghai",supplierID:5),
            };
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}", Name, SupplierID);
        }
    }
}
