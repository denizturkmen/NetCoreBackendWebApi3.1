using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi3._0.Entity;
using NetCoreWebApi3._0.Models;

namespace NetCoreWebApi3._0.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        Person GetById(int id);

        void Create(Person entity);
        void Delete(Person entity);
        void Update(Person entity);

    }
}
