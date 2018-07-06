using ExamenProject.BL.IServices;
using ExamenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenProject.BL.Shared
{
    public abstract class ServiceGeneral<T> : IServiceGeneral<T>
    {
        public virtual T GetById(ref BaseEntity objEntity, Int32 Id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> List(ref BaseEntity objEntity)
        {
            throw new NotImplementedException();
        }

        public virtual Boolean Save(ref BaseEntity objEntity, T obj)
        {
            throw new NotImplementedException();
        }

        public virtual Boolean Update(ref BaseEntity objEntity, T obj)
        {
            throw new NotImplementedException();
        }
        
        public virtual Boolean IsErrorsOrNull(ref BaseEntity objEntity, List<T> lst)
        {
            Boolean result = false;
            if (lst.Count > 0) result = true;
            return result;
        }
    }
}