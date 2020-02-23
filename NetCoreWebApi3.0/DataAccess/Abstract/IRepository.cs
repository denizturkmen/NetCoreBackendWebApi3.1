﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi3._0.Models;

namespace NetCoreWebApi3._0.DataAccess.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity GetById(int id);

        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);


    }
}
