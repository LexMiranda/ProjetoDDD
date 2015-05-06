﻿using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Interface.Repositories;
using ProjetoModeloDDD.Domain.Interface.Services;

namespace ProjetoModeloDDD.Domain.services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity :class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();

        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);

        }

        void IServiceBase<TEntity>.Dispose()
        {
            _repository.Dispose();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}