using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface IService<TEntity> where TEntity:class
    {
        Task<TEntity> GetByIdAsync(int id); //id ye göre ürün getir.
        Task<IEnumerable<TEntity>> GetAllAsync(); //tüm nesneleri getir
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);    //find(x=>x.id =23)
        // category.SingleOrDefaultAsync(x=>x.name="kalem")
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
        TEntity Update(TEntity entity);
    }
}
