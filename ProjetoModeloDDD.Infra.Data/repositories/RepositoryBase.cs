

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Context;

namespace ProjetoModeloDDD.Infra.Data.repositories
{   
    public class RepositoryBase<TEntity> :IDisposable, IRepositoryBase<TEntity> where TEntity : class 
    {
        protected ProjetoModeloContext Db = new ProjetoModeloContext();

        // minhas implementações
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
