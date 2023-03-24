using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
  public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
  {
    public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
  }
}
