using Busniess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.DTOs;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace Busniess.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _productDal;


        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //yetkisi var mı?

            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p =>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetail()
        {
            return _productDal.GetProductDetail();
        }
    }
}
