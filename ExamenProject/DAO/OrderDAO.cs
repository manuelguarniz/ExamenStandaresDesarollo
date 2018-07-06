using ExamenProject.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExamenProject.DAO
{
    public class OrderDAO
    {
        #region Singleton
        private static readonly OrderDAO _instance = new OrderDAO();
        public static OrderDAO Instance {
            get { return OrderDAO._instance; }
        }
        #endregion Singleton

        public List<Order> Order_GetAll(ref BaseEntity Base)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            List<Order> lst = new List<Order>();
            Order order = null;
            try
            {
                connection = new SqlConnection();
                SqlCommand command = new SqlCommand("sp_xd", connection);
                command.CommandType = CommandType.StoredProcedure;
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    order = new Order();
                    //Get Data
                    lst.Add(order);
                }
            }
            catch (Exception ex)
            {
                lst = null;
            }
            finally
            {
                connection.Close();
            }
            return lst;
        }
    }
}