using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreWebApi3._0.DataAccess.Abstract;
using NetCoreWebApi3._0.Entity;

namespace NetCoreWebApi3._0.DataAccess.Concrete.EntityFrameWorkCore
{
    public class EfCorePersonDal:EfCoreGenericRepository<Person,DatabaseContext>,IPersonDal
    {

    }
}
