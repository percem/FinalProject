using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class kalmasın = Category gibi bir inheritence ya da interface almazsa ileride problem yaşarız. IEntity yazınca using'i yap
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
