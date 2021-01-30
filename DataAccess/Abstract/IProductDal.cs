using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        //Önce Business->Sağ Tık Project Referance yaptık sonr using ekledik
        //Interface özellikleri default publictir, interface public.
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllCategory(int categoryId);

    }
}
