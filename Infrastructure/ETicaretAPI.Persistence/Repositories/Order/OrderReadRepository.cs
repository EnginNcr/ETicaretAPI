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
  public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
  {
    public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
  }
}
