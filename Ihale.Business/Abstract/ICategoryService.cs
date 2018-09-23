using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using Ihale.Entity.ComplexType;
using Ihale.Entity.Concrete;

namespace Ihale.Business.Abstract
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        IEnumerable<Category> GetAll();

        [OperationContract]
        Category Get(int id);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        Category Add(Category category);

        [OperationContract]
        Category Update(Category category);

    }
    
}