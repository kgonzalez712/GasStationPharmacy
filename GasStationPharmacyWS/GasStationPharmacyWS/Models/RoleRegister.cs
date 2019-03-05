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

        public static RoleRegister GetInstance()
        {
            if (roleReg == null)
            {
                roleReg=new RoleRegister();
                return roleReg;
            }

            return roleReg;
        }

        public List<Role> GetAllRole(List<Role> list)
        {
            return list;
        }

        public Role GetRole(List<Role> list, string id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.RoleName.Equals(id)) return c;
            }

            return null;
        }

        public void AddRole(List<Role> list, Role r)
        {
            list.Add(r);
        }

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