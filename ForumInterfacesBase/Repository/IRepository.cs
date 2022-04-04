using ForumInterfacesBase.Entity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ForumInterfacesBase.Repository
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        bool AutoSaveChanges { get; set; }

        
        IEnumerable<T> GetAll { get; }
        Task<IEnumerable<T>> GetAllAsync(CancellationToken Cancel = default);
        
        T GetById(int id);
        Task<T> GetByIdAsync(int id, CancellationToken Cancel = default);

        T Add(T entity);
        Task<T> AddAsync(T entity, CancellationToken Cancel = default);

        T Update(T entity);
        Task<T> UpdateAsync(T entity, CancellationToken Cancel = default);

        T Delete(T entity);
        Task<T> DeleteAsync(T entity, CancellationToken Cancel = default);

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken Cancel = default);

    }
}
