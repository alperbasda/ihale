
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Ihale.Business.Abstract;
using Ihale.Business.DepandencyResolvers.Ninject;
using Ihale.Entity.ComplexType;
using Ihale.Entity.Concrete;

public class CategoryService : ICategoryService
{
    public CategoryService()
    {

    }

    private ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();


    public IEnumerable<Category> GetAll()
    {
   
        return _categoryService.GetAll();
    }

    public Category Get(int id)
    {
        return _categoryService.Get(id);
    }

    public bool Delete(int id)
    {
        return _categoryService.Delete(id);
    }

    public Category Add(Category category)
    {
        return _categoryService.Add(category);
    }

    public Category Update(Category category)
    {
        return _categoryService.Update(category);
    }
}

