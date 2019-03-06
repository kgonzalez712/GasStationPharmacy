using System;
using System.Collections.Generic;
using System.Linq;

namespace GasStationPharmacyWS.Models
{
    public class DoctorRegister
    {

        public static List<Doctor> docListP;
        public static List<Doctor> docListB;

        private static DoctorRegister docReg;

        private DoctorRegister()
        {
            docListP = new List<Doctor>();
            docListB = new List<Doctor>();
            var a = new Doctor();
            var b = new Doctor();

            a.DoctorId = 3245875245;
            a.DoctorDid = 345;
            a.DoctorFirstName = "Dr. Mario";
            a.DoctorLastName = "lele";
            a.DoctorBirthday = DateTime.Parse("07/23/1890");
            a.DoctorAddress = "huehue";
            a.AccountPassword = "zxc";

            b.DoctorId = 34575788;
            b.DoctorDid = 45;
            b.DoctorFirstName = "lolo";
            b.DoctorLastName = "lulu";
            b.DoctorBirthday = DateTime.Parse("07/11/1890");
            b.DoctorAddress = "huue";
            b.AccountPassword = "asdf";

            docListP.Add(a);
            docListB.Add(b);
        }

        /// <summary>
        /// Maneja una sola instancia de doctor para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static DoctorRegister GetInstance()
        {
            if (docReg == null)
            {
                docReg = new DoctorRegister();
                return docReg;
            }

            return docReg;
        }

        /// <summary>
        /// retorna los doctores para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de doctores </returns>
        public List<Doctor> GetAllDoctors(List<Doctor> list)
        {
            return list;
        }


        /// <summary>
        /// retorna un doctor para las dos farmacias
        /// </summary>
        /// <returns> Un doctor </returns>
        public Doctor GetDoctor(List<Doctor> list, long id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.DoctorDid.Equals(id)) return c;
            }

            return null;
        }

        /// <summary>
        /// Añade administradores para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddDoctor(List<Doctor> list, Doctor doc)
        {
            list.Add(doc);
            if (list.Equals(docListP))
            {
                Role r = new Role();
                r.RoleName = "Doctor";
              
                r.RoleDescription = "Doctor of Phischel Pharmacy";
                RoleRegister.GetInstance().AddRole(RoleRegister.roleListP,r);
            }
            else
            {
                Role r = new Role();
                r.RoleName = "Doctor";
                r.RoleDescription = "Doctor of Phischel Pharmacy";
                RoleRegister.GetInstance().AddRole(RoleRegister.roleListB, r);
            }
        }

        /// <summary>
        /// Elimina doctores para las dos farmacias
        /// </summary>
        /// <returns> false si no lo elimina, true si lo elimina </returns>
        public bool RemoveDoctor(List<Doctor> list, long id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.DoctorDid.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }

        /// <summary>
        /// modifica doctores para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateDoctor(List<Doctor> list, long id, Doctor value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.DoctorDid.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }

            return action;
        }

        //public bool UpdateDoctorLN(List<Doctor> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.DoctorDid.Equals(id))
        //        {
        //            c.DoctorLastName = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateDoctorAD(List<Doctor> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.DoctorDid.Equals(id))
        //        {
        //            c.DoctorAddress = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateDoctorAP(List<Doctor> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.DoctorDid.Equals(id))
        //        {
        //            c.AccountPassword = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateDoctorB(List<Doctor> list, long id, DateTime value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.DoctorDid.Equals(id))
        //        {
        //            c.DoctorBirthday = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}
    }
}