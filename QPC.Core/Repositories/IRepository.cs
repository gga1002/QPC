﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace QPC.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> expr);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        List<TEntity> PageAll(int skip, int take);
        Task<List<TEntity>> PageAllAsync(int skip, int take);
        Task<List<TEntity>> PageAllAsync(CancellationToken cancellationToken, int skip, int take);

        TEntity FindById(object id);
        Task<TEntity> FindByIdAsync(object id);
        Task<TEntity> FindByIdAsync(CancellationToken cancellationToken, object id);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }
}
