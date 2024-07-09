using Ventas.Data.Context;
using Ventas.Data.Interfaces.Repositories;
using Ventas.Data.Entities;

namespace Ventas.Data.Repositories
{
    public class ProductosRepository : GenericRepository<Producto>, IProductosRepository 
    { 
            public readonly AzurePracticeContext _context;

            public ProductosRepository(AzurePracticeContext context) : base(context)
            {
                _context = context;
            }


    }
}
