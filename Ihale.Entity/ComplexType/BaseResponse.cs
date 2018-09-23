using System.Collections.Generic;
using Ihale.Core.Entity;
using Ihale.Entity.Concrete;

namespace Ihale.Entity.ComplexType
{
    
    public class BaseResponse : Entities
    {      
        public bool Success { get; set; }
    
        public object Data { get; set; }

        public string Message { get; set; }
    }
}