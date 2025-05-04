using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbearia.Domain.Interfaces.Repositories._Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(params object[] parameters);
        void Delete(TEntity entity);
        TEntity Update(TEntity updated, TEntity existing);
        TEntity Add(TEntity entity);
        void SaveChanges();
        
    }
}
