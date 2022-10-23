using Core.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepostory<Product>
    {
        //Producta özel kısımlar
        List<ProductDetailDto> GetProductDetail();
    }
}


//code refactoring