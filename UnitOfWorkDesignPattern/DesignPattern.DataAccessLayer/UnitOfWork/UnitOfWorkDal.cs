using DesignPattern.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DataAccessLayer.UnitOfWork
{
    public class UnitOfWorkDal : IUnitOfWorkDal
    {
        private readonly Context _context;

        public UnitOfWorkDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
