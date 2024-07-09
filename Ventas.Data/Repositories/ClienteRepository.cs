using Ventas.Data.Context;
using Ventas.Data.Interfaces.Repositories;
using Ventas.Data.Entities;

namespace Ventas.Data.Repositories
{
    public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository 
    { 
            public readonly AzurePracticeContext _context;

            public ClienteRepository(AzurePracticeContext context) : base(context)
            {
                _context = context;
            }


    }
}
