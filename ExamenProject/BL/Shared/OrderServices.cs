using ExamenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenProject.BL.Shared
{
    public abstract class OrderServices<T> : ServiceGeneral<T>
    {
        public override T GetById(ref BaseEntity objEntity, Int32 Id)
        {
            return base.GetById(ref objEntity, Id);
        }

        public override List<T> List(ref BaseEntity objEntity)
        {
            return base.List(ref objEntity);
        }

        public override Boolean Save(ref BaseEntity objEntity, T objOrder)
        {
            return base.Save(ref objEntity, objOrder);
        }

        public override Boolean Update(ref BaseEntity objEntity, T objOrder)
        {
            return base.Update(ref objEntity, objOrder);
        }
        
    }
}