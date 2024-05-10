using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetById(int id);
        void MultiUpdate(List<T> t);
    }
}
