using Ventas.Data.Context;
using Ventas.Data.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ventas.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    { 
            public readonly AzurePracticeContext _context;

            public GenericRepository(AzurePracticeContext context)
            {
                _context = context;
            }

            public virtual async Task<T> Add(T entity)
            {
                await _context.Set<T>().AddAsync(entity);
                await _context.SaveChangesAsync();

                return entity;
            }



            public virtual async Task<T> GetById(int id)
            {
                return await _context.Set<T>().FindAsync(id);
            }

            public virtual async Task Remove(T entity)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }

            public virtual async Task Update(T entity)
            {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            }

            public virtual async Task<List<T>> GetAll()
            {
                return await _context.Set<T>().ToListAsync();
            }


        
    }
}
