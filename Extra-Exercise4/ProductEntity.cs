using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Exercise4
{
    class ProductEntity
    {
        public enum ProductStateEnum {InStock,OutOfStock,NotForSale};

        public ProductStateEnum Status ;
        public string Name;
        public int Id;

        public ProductEntity( ProductStateEnum status, int id, string name)
        {
            Status = status;
            Id = id;
            Name = name;


        }


        public override string ToString()
        {
            return ("");
        }
    }
}
