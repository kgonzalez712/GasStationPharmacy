﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    public class OrderRegister
    {
        public static List<Order> orderListB;
        public static List<Order> orderListP;
        private static OrderRegister orderReg;

        private OrderRegister()
        {
            orderListB = new List<Order>();
            orderListP = new List<Order>();
            var a = new Order();
            a.OrderId = 123456;
            a.OrderBranch = "Pischel Cartgo";
            a.OrderClient = "Carlos";
            a.OrderMeds = "aceta=2,loratadina=3";
            a.OrderPhoneNo = 89974260;
            a.OrderTime = DateTime.Parse("12:30 PM");
            a.OrderUrl = "www.url.com";

            var b = new Order();
            b.OrderId = 123456;
            b.OrderBranch = "BombaTica Cartgo";
            b.OrderClient = "Charles";
            b.OrderMeds = "aceta=2,loratadina=3";
            b.OrderPhoneNo = 89974260;
            b.OrderTime = DateTime.Parse("12:30 PM");
            b.OrderUrl = "www.url.com";


            orderListP.Add(a);
            orderListB.Add(a);
        }

        /// <summary>
        /// Maneja una sola instancia de orden para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static OrderRegister GetInstance()
        {
            if (orderReg == null)
            {
                orderReg = new OrderRegister();
                return orderReg;
            }

            return orderReg;
        }


        /// <summary>
        /// retorna las ordenes para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de ordenadores </returns>
        public List<Order> GetAllOrders(List<Order> list)
        {
            return list;
        }

        /// <summary>
        /// retorna una orden para las dos farmacias
        /// </summary>
        /// <returns> Una orden </returns>
        public Order GetOrder(List<Order> list, int id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.OrderId.Equals(id)) return c;
            }

            return null;
        }

        /// <summary>
        /// Añade ordenes para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddOrder(List<Order> list, Order r)
        {
            list.Add(r);
        }

        /// <summary>
        /// Elimina ordenes para las dos farmacias
        /// </summary>
        /// <returns> false si no lo ordenes, true si lo elimina </returns>
        public bool RemoveOrder(List<Order> list, int id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.OrderId.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }


        /// <summary>
        /// modifica ordenes para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateOrder(List<Order> list, int id, Order value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.OrderId.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }

            return action;
        }
    }
}