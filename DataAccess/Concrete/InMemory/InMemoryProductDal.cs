using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        //Tanımlanan nitelik class içinde olduğu için globaldir ve bu tip nitelikler genelde isimlendirmeye _ ile başlar
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Bir veritabanından geliyormuş gibi ürün listesi oluşturduk
            _products = new List<Product> { 
                new Product{ProductID=1, CategoryID=1, ProductName="Bardak", UnitPrice=15, UnitInStock=15},
                new Product{ProductID=2, CategoryID=1, ProductName="Kamera", UnitPrice=500, UnitInStock=3},
                new Product{ProductID=3, CategoryID=2, ProductName="Telefon", UnitPrice=1500, UnitInStock=2},
                new Product{ProductID=4, CategoryID=2, ProductName="Klavye", UnitPrice=150, UnitInStock=65},
                new Product{ProductID=5, CategoryID=2, ProductName="Mouse", UnitPrice=85, UnitInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Tek tek yukarıdaki elemanları dolanıp Id'lerine bakıyoruz eğer Id tutarsa o eleman silinir
            //Product productToDelete=null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductID == p.ProductID)
            //    {
            //        productToDelete = p;
            //    }
            //}
            //LINQ - Language Integrated Query
            //p=> demek Lambda demek; Bu single kodu foreach'ı tek başına yapıyor
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);
            //Her p için o an dolaştığım ürünün ID'si parametre olarak gönderdiğim ürün ID'sine eşitse sil
            _products.Remove(productToDelete);
        }


        //Veritabanındakini direkt business'e vermeli
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderilen ürün ID'sine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

    }
}
