using AutoMapper;
using BlogApp.Business.DTOs.CarDTOs;
using BlogApp.Business.Services.Interfaces;
using BlogApp.Core.Entities;
using BlogApp.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _rep;
        private readonly IMapper _mapper;

        public CarService(ICarRepository rep, IMapper mapper = null)
        {
            _rep = rep;
            _mapper = mapper;
        }

        public async Task<IQueryable<Car>> GetAllAsync(Expression<Func<Car, bool>>? expression = null, params string[] includes)
        {
            return await _rep.GetAllAsync(expression, includes);
        }

        public async Task<Car> GetByIdAsync(int Id)
        {
            return await _rep.GetByIdAsync(Id);

        }
        public async Task<Car> CreateAsync(CreateCarDTO entity)
        {
            Car newCar = _mapper.Map<Car>(entity);

            _rep.CreateAsync(newCar);
            _rep.SaveChangesAsync();

            return newCar;
        }
        public async Task<Car> UpdateAsync(UpdateCarDTO entity)
        {
            Car oldCar = await _rep.GetByIdAsync(entity.Id);
            _mapper.Map(entity, oldCar);

            _rep.UpdateAsync(oldCar);
            _rep.SaveChangesAsync();

            return oldCar;
        }
        public async void DeleteAsync(int Id)
        {
            Car oldCar = await _rep.GetByIdAsync(Id);

            _rep.DeleteAsync(oldCar);
            _rep.SaveChangesAsync();
        }
    }
}
