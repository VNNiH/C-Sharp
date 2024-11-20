using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio5
{
    class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
        public UsedProduct() { }
        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name,price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price
                + " (Manufacture date: "
                + ManufacturedDate.ToString()
                + ")";
        }
    }
}
