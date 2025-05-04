using Barbearia.Domain.Interfaces.Repositories._Base;
using Barbearia.Domain.Interfaces.Services._Base;

namespace Barbearia.Domain.Services._Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity entity)
        {
            _repository.Add(entity);
            _repository.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
            _repository.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(params object[] parameters)
        {
            return _repository.GetById(parameters);
        }

        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public TEntity Update(TEntity updated, TEntity existing)
        {
            if (updated == null)
                return null!;
            _repository.Update(updated, existing);
            _repository.SaveChanges();
            return updated;
        }
    }
}
