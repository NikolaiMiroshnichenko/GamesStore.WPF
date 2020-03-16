using GamesStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.DAL.Repositories
{
    public class Repository<TEntity>
        where TEntity : Entity
    {
        private DbContext _context;

        public Repository(DbContext gamesStoreContext)
        {
            _context = gamesStoreContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }
        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            var dbSet = _context.Set<TEntity>();
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
