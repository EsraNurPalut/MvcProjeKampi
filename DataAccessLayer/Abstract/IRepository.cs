﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T>  //Hepsini tek tek ıcotegorydal gibi yazmaktansa hespni t ye tanımladık 
    {
        List<T> List();

        void Insert(T p);

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter);  //sartlı listeleme yapmak için 

    }
}