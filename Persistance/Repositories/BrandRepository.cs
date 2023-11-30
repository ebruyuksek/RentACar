using Application.Services.Repositories;
using Core.Persistance.Repositories;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistence.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
{
    //base bir context parametresi aldığı için constructor oluşturmalıyız
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }
}
