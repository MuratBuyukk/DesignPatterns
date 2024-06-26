﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);
        List<T> TGetList();
        T TGetById(int id);
        void TMultiUpdate(List<T> t);
    }
}
