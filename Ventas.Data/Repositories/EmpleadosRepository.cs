using Ventas.Data.Context;
using Ventas.Data.Interfaces.Repositories;
using Ventas.Data.Entities;

namespace Ventas.Data.Repositories
{
    public class EmpleadosRepository : GenericRepository<Empleado>, IEmpleadosRepository 
    { 
            public readonly AzurePracticeContext _context;

            public EmpleadosRepository(AzurePracticeContext context) : base(context)
            {
                _context = context;
            }


    }
}
