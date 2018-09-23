using System.Linq;
using AutoMapper;
using Ihale.Business.Abstract;
using Ihale.Entity.ComplexType;
using Ihale.Entity.Concrete;

namespace Ihale.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile :Profile
    {
        public BusinessProfile()
        {
            CreateMap<BaseResponse, BaseResponse>();
            CreateMap<Category, Category>();
            CreateMap<CategoryFilter, CategoryFilter>();
            CreateMap<CategoryFilterDescription, CategoryFilterDescription>();
            CreateMap<CategoryFilterDescriptionAuctionRelation, CategoryFilterDescriptionAuctionRelation>();
            CreateMap<CategoryFilterRelation, CategoryFilterRelation>();
            
        }
    }
}