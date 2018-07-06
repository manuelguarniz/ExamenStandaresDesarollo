using ExamenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProject.BL.IServices
{
    interface IServiceGeneral<T>
    {
        List<T> List(ref BaseEntity objEntity);
        Boolean Save(ref BaseEntity objEntity, T obj);
        Boolean Update(ref BaseEntity objEntity, T obj);
        T GetById(ref BaseEntity objEntity, Int32 Id);
    }
}
