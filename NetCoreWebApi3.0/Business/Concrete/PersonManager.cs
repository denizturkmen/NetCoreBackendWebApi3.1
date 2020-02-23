using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebApi3._0.Business.Abstract;
using NetCoreWebApi3._0.DataAccess.Abstract;
using NetCoreWebApi3._0.Entity;
using NetCoreWebApi3._0.Models;

namespace NetCoreWebApi3._0.Business.Concrete
{
    public class PersonManager : IPersonService
    {

        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public Person GetById(int id)
        {
            return _personDal.GetById(id);
        }

        public void Create(Person entity)
        {
            _personDal.Create(entity);
        }

        public void Delete(Person entity)
        {
           _personDal.Delete(entity);
        }

        public void Update(Person entity)
        {
            _personDal.Update(entity);
        }
    }
}
