using ExamenProject.Entity;
using ExamenProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamenProject.BL.Orders;
using ExamenProject.BL.Shared;

namespace ExamenProject
{
    public partial class _Default : Page
    {
        private static OrderServices<Order> _servicesOrder;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        [WebMethod]
        public static List<Object> OrderEntry_GetAll()
        {
            List<Object> lst = null;
            BaseEntity entity = new BaseEntity();

            try
            {
                BaseEntity objEntity = new BaseEntity();
                List<Order> lstOrder = OrderBL.Instance.List(ref objEntity);
                if (!_servicesOrder.IsErrorsOrNull(ref objEntity, lstOrder))
                {
                    lst = new List<object>();
                    foreach (Order item in lstOrder)
                    {
                        Object obj = new
                        {
                            Id = item.Id,
                            LegacyNumber = item.LegacyNumber,
                            DistributorId = item.DistributorId,
                            OrderTotal = item.OrderTotal,
                            Status = item.Status
                        };

                        lst.Add(obj);
                    }
                }
                else
                {
                    Object obj = new
                    {
                        Id = "",
                        LegacyNumber = "",
                        DistributorId = "",
                        OrderTotal = "",
                        Status = ""
                    };

                    lst.Add(obj);
                }
            }
            catch (Exception ex)
            {
            }
            return lst;
        }
    }
}