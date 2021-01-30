using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Public = Bu class'a diğer katmanlar da ulaşabilsin demektir.
    //Internal = Bu class'a sadece Entities ulaşabilir demektir.
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
