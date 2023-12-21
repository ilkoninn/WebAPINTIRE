using BlogApp.Business.DTOs.BrandDTOs;
using BlogApp.Core.Entities;
using System.Linq.Expressions;

namespace BlogApp.Business.Services.Interfaces
{
    public interface IBrandService
    {
        Task<IQueryable<Brand>> GetAllAsync(Expression<Func<Brand, bool>>? expression = null, params string[] includes);
        Task<Brand> GetByIdAsync(int Id);
        Task<Brand> CreateAsync(CreateBrandDTO entity);
        Task<Brand> UpdateAsync(UpdateBrandDTO entity);
        void DeleteAsync(int Id);
    }
}
