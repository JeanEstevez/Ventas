using Ventas.Data.Context;
using Ventas.Data.Interfaces.Repositories;
using Ventas.Data.Entities;

namespace Ventas.Data.Repositories
{
    public class ProveedoresRepository: GenericRepository<Proveedore>, IProveedoresRepository 
    { 
            public readonly AzurePracticeContext _context;

            public ProveedoresRepository(AzurePracticeContext context) : base(context)
            {
                _context = context;
            }


    }
}
