using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using Ihale.Business.Abstract;
using Ihale.DataAccess.Concrete.EntityFramework;
using Ihale.Entity.ComplexType;
using Ihale.Entity.ComplexType.GetModels.PageModels;
using Ihale.Entity.Concrete;

namespace Ihale.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private CategoryDal _categoryDal;
        private IMapper _mapper;
        public CategoryManager(CategoryDal categoryDal,IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public IEnumerable<Category> GetAll()
        {
            List<Category> cat = _categoryDal.GetList();
            return _mapper.Map<List<Category>>(_categoryDal.GetList());

        }

        public Category Get(int id)
        {
            return _mapper.Map<Category>(_categoryDal.Get(s=>s.Id==id));
        }

        public bool Delete(int id)
        {
            _categoryDal.Delete(_categoryDal.Get(s => s.Id == id));
            return true;
        }

        public Category Add(Category category)
        {

            return _mapper.Map<Category>(_categoryDal.Add(category));
        }

        public Category Update(Category category)
        {
            
            return _mapper.Map<Category>(_categoryDal.Update(category));
        }
    }
}