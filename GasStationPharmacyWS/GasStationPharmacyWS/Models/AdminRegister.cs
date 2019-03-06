using System;
using System.Collections.Generic;
using System.Linq;

namespace GasStationPharmacyWS.Models
{
    public class AdminRegister
    {
        public static List<Admin> adminListB;
        public static List<Admin> adminListP;
        private static AdminRegister adminReg;

        private AdminRegister()
        {
            adminListB = new List<Admin>();
            adminListP = new List<Admin>();
            var a = new Admin();
            var b = new Admin();
            a.AdminId = 345;
            a.AdminFirstName = "lala";
            a.AdminLastName = "lele";
            a.AdminBirthday = DateTime.Parse("07/23/1890");
            a.AdminAddress = "huehue";
            a.AdminAccountPassword = "123344";
            a.AdminAccountEmail = "prueba@email.com";


            b.AdminId = 3444;
            b.AdminFirstName = "lolo";
            b.AdminLastName = "lulu";
            b.AdminBirthday = DateTime.Parse("07/11/1890");
            b.AdminAddress = "huue";
            b.AdminAccountPassword = "123344";
            b.AdminAccountEmail = "prueba@email.com";

            adminListP.Add(a);
            adminListB.Add(b);
        }

        /// <summary>
        /// Maneja una sola instancia de administrador para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static AdminRegister GetInstance()
        {
            if (adminReg == null)
            {
                adminReg = new AdminRegister();
                return adminReg;
            }

            return adminReg;
        }

        /// <summary>
        /// retorna los administradores para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de administradores </returns>
        public List<Admin> GetAllAdmins(List<Admin> list)
        {
            return list;
        }

        /// <summary>
        /// retorna un administrador para las dos farmacias
        /// </summary>
        /// <returns> Un administrador </returns>
        public Admin GetAdmin(List<Admin> list, long id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.AdminId.Equals(id)) return c;
            }

            return null;
        }

        /// <summary>
        /// Añade administradores para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddAdmin(List<Admin> list, Admin ad)
        {
            list.Add(ad);
        }

        /// <summary>
        /// Elimina administradores para las dos farmacias
        /// </summary>
        /// <returns> false si no lo elimina, true si lo elimina </returns>
        public bool RemoveAdmin(List<Admin> list, long id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.AdminId.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }

        /// <summary>
        /// modifica administradores para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateAdmin(List<Admin> list, long id, Admin value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.AdminId.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }

            return action;
        }

        //public bool UpdateAdminLN(List<Admin> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.AdminId.Equals(id))
        //        {
        //            c.AdminLastName = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateAdminAD(List<Admin> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.AdminId.Equals(id))
        //        {
        //            c.AdminAddress = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateAdminAE(List<Admin> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.AdminId.Equals(id))
        //        {
        //            c.AdminAccountEmail = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateAdminAP(List<Admin> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.AdminId.Equals(id))
        //        {
        //            c.AdminAccountPassword = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateAdmintB(List<Admin> list, long id, DateTime value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.AdminId.Equals(id))
        //        {
        //            c.AdminBirthday = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}
    }
}