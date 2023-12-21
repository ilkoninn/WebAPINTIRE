using BlogApp.Business.DTOs.CarDTOs;
using BlogApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Interfaces
{
    public interface ICarService
    {
        Task<IQueryable<Car>> GetAllAsync(Expression<Func<Car, bool>>? expression = null, params string[] includes);
        Task<Car> GetByIdAsync(int Id);
        Task<Car> CreateAsync(CreateCarDTO entity);
        Task<Car> UpdateAsync(UpdateCarDTO entity);
        void DeleteAsync(int Id);
    }
}
