using ExamenProject.BL.Shared;
using ExamenProject.DAO;
using ExamenProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenProject.BL.Orders
{
    public class OrderBL : OrderServices<Order>
    {
        #region Singleton
        private static readonly OrderBL _instance = new OrderBL();
        public static OrderBL Instance {
            get { return OrderBL._instance; }
        }
        #endregion Singleton

        private OrderServices<Order> _servicesOrder;
        
        public override List<Order> List(ref BaseEntity objEntity)
        {
            return OrderDAO.Instance.Order_GetAll(ref objEntity);
        }

        public override Boolean Save(ref BaseEntity objEntity, Order objOrder)
        {
            return base.Save(ref objEntity, objOrder);
        }

    }
}