using Barbearia.Domain.Interfaces.Repositories._Base;
using Barbearia.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Barbearia.Infra.Data.Repositories._Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly BarbeariaContext _context;
        public List<Expression<Func<TEntity, object>>> IncludeList { get; private set; } = [];
        protected DbSet<TEntity> Entity
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }
        public RepositoryBase(BarbeariaContext context)
        {
            _context = context;
        }

        public TEntity Add(TEntity entity)
        {
            Entity.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            Entity.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = Entity;
            foreach (var inc in IncludeList)
            {
                query = query.Include(inc);
            }
            var r = query.AsNoTracking().AsEnumerable();
            IncludeList.Clear();
            return r;
        }

        public TEntity GetById(params object[] parameters)
        {
            return Entity.Find(parameters);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public TEntity Update(TEntity updated, TEntity existing)
        {
            if (updated == null)
                return null!;

            _context.Entry(existing).CurrentValues.SetValues(updated);
            _context.SaveChanges();

            return updated;
        }
    }
    }
