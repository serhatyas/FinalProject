using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busniess.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

    }
}
