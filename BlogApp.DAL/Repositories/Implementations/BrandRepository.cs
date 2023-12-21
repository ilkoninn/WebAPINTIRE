using BlogApp.Core.Entities;
using BlogApp.DAL.Context;
using BlogApp.DAL.Repositories.Interfaces;

namespace BlogApp.DAL.Repositories.Implementations
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context) { }
    }
}
