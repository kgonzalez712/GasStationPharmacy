using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    public class RoleRegister
    {
        public static List<Role> roleListB;
        public static List<Role> roleListP;
        private static RoleRegister roleReg;

        private RoleRegister()
        {
            roleListB=new List<Role>();
            roleListP=new List<Role>();
            var a = new Role();
            a.RoleName = "Bodeguero";
            a.RoleDescription = "Simple Bodeguero";
            roleListB.Add(a);
            roleListP.Add(a);
        }

        /// <summary>
        /// Maneja una sola instancia de rol para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static RoleRegister GetInstance()
        {
            if (roleReg == null)
            {
                roleReg=new RoleRegister();
                return roleReg;
            }

            return roleReg;
        }

        /// <summary>
        /// retorna los roles para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de role </returns>
        public List<Role> GetAllRole(List<Role> list)
        {
            return list;
        }

        /// <summary>
        /// retorna un rol para las dos farmacias
        /// </summary>
        /// <returns> Una rol </returns>
        public Role GetRole(List<Role> list, string id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RoleName.Equals(id)) return c;
            }

            return null;
        }

        /// <summary>
        /// Añade roles para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddRole(List<Role> list, Role r)
        {
            list.Add(r);
        }

        /// <summary>
        /// modifica administradores para las dos farmacias
        /// </summary>
        /// <returns> false si no lo elimina, true si lo elimina </returns>
        public bool Remove(List<Role> list, string id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RoleName.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }


        /// <summary>
        /// modifica roles para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateRole(List<Role> list, string id, Role value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RoleName.Equals(id))
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