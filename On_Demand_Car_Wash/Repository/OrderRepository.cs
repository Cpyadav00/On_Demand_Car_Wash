﻿using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.DataBaseContext;
using On_Demand_Car_Wash.Interface;
using On_Demand_Car_Wash.Model;

namespace On_Demand_Car_Wash.Repository
{
    public class OrderRepository : IOrder
    {
        private CarDbContext _orderDb;
        public OrderRepository(CarDbContext orderDbContext)
        {
            _orderDb = orderDbContext;
        }
        public List<Order> GetAllOrder()
        {
            List<Order> orders = null;
            try
            {
                orders = _orderDb.Orders.ToList();
            }
            catch (Exception ex) { }
            return orders;
        }
        public Order GetOrder(int id)
        {
            Order order;
            try
            {
                order = _orderDb.Orders.Find(id);
                if (order != null)
                {
                    return order;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException();
            }
            finally
            {
                order = null;
            }
            return order;
        }
        public string AddOrder(Order order)
        {
            string result = string.Empty;
            try
            {
                _orderDb.Orders.Add(order);
                _orderDb.SaveChanges();
            }
            catch (Exception ex)
            {
                result = "400";
            }
            return result;
        }
        public string UpdateOrder(Order order)
        {
            string result = string.Empty;
            try
            {
                _orderDb.Entry(order).State = EntityState.Modified;
                _orderDb.SaveChanges();
                result = "200";
            }
            catch
            {
                result = "400";
            }
            return result;
        }
        public string DeleteOrder(int id)
        {
            string result = string.Empty;
            Order order;
            try
            {
                order = _orderDb.Orders.Find(id);
                if (order != null)
                {
                    //package.Status = "In Active";
                    _orderDb.Orders.Remove(order);
                    _orderDb.SaveChanges();
                    result = "200";
                }
            }
            catch (Exception ex)
            {
                result = "400";
            }
            finally
            {
                order = null;
            }
            return result;
        }
    }
}
