using AutoMapper;
using BlogApp.Business.DTOs.BrandDTOs;
using BlogApp.Business.Services.Interfaces;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repositories.Implementations;
using BlogApp.DAL.Repositories.Interfaces;
using System.Linq.Expressions;

namespace BlogApp.Business.Services.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _rep;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository rep, IMapper mapper = null)
        {
            _rep = rep;
            _mapper = mapper;
        }

        public async Task<IQueryable<Brand>> GetAllAsync(Expression<Func<Brand, bool>>? expression = null, params string[] includes)
        {
            return await _rep.GetAllAsync(expression, includes);
        }

        public async Task<Brand> GetByIdAsync(int Id)
        {
            return await _rep.GetByIdAsync(Id);

        }
        
        public async Task<Brand> CreateAsync(CreateBrandDTO entity)
        {
            Brand newBrand = new();
            _mapper.Map<Brand>(entity);  
        
            _rep.CreateAsync(newBrand);
            _rep.SaveChangesAsync();
        
            return newBrand;
        }
        
        public async Task<Brand> UpdateAsync(UpdateBrandDTO entity)
        {
            Brand oldBrand = await _rep.GetByIdAsync(entity.Id);
            _mapper.Map(entity, oldBrand);

            _rep.UpdateAsync(oldBrand);
            _rep.SaveChangesAsync();

            return oldBrand;
        }
        
        public async void DeleteAsync(int Id)
        {
            Brand oldBrand = await _rep.GetByIdAsync(Id);

            _rep.DeleteAsync(oldBrand);
            _rep.SaveChangesAsync();
        }        
    }
}
