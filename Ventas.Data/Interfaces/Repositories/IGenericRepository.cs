namespace Ventas.Data.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task Update(T entity, int id);
        Task Remove(T entity);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
