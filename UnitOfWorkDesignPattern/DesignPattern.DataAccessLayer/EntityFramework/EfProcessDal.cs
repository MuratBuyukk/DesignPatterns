using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProcessDal:GenericRepository<Process>,IProcessDal
    {
        public EfProcessDal(Context context) : base(context) { }
    }
}
