using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IRepository<TEntity,TKey>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(TKey Id);
        TEntity Create(TEntity newentity);
        bool Save();
        bool Delete(TEntity entity);
    }
}
