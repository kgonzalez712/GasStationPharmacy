using System.Collections.Generic;
using System.Linq;

namespace GasStationPharmacyWS.Models
{
    public class MedicineRegister
    {
        public static List<Medicine> medListB;
        public static List<Medicine> medListP;
        private static MedicineRegister medReg;

        private MedicineRegister()
        {
            medListB = new List<Medicine>();
            medListP = new List<Medicine>();

            var a = new Medicine();
            a.MedicineName = "Paracetamol";
            a.MedicineRequirePrescription = "no";
            a.MedicineQuantity = 100;
            a.MedicinePrice = 100;
            a.MedicinePH = "Drogadigtos&Asociados";

            medListB.Add(a);
            medListP.Add(a);
        }

        /// <summary>
        /// Maneja una sola instancia de medicina para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static MedicineRegister GetInstance()
        {
            if (medReg == null)
            {
                medReg = new MedicineRegister();
                return medReg;
            }

            return medReg;
        }

        /// <summary>
        /// retorna las medicinas para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de medicinas </returns>
        public List<Medicine> GetAllMedicines(List<Medicine> list)
        {
            return list;
        }

        /// <summary>
        /// retorna una medicina para las dos farmacias
        /// </summary>
        /// <returns> Una medicina </returns>
        public Medicine GetMedicine(List<Medicine> list, string name)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.MedicineName.Equals(name)) return c;
            }

            return null;
        }

        /// <summary>
        /// Añade medicinas para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddMedicine(List<Medicine> list, Medicine med)
        {
            list.Add(med);
        }

        /// <summary>
        /// Elimina medicinas para las dos farmacias
        /// </summary>
        /// <returns> false si no lo elimina, true si lo elimina </returns>
        public bool RemoveMedicine(List<Medicine> list, string id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.MedicineName.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }


        /// <summary>
        /// modifica medicinas para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateMedicine(List<Medicine> list, string id, Medicine value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.MedicineName.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }
            return action;
        }



        //public bool UpdateMediceQ(List<Medicine> list, string id, int value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.MedicineName.Equals(id))
        //        {
        //            c.MedicineQuantity = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateMediceP(List<Medicine> list, string id, int value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.MedicineName.Equals(id))
        //        {
        //            c.MedicinePrice = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateMediceRP(List<Medicine> list, string id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.MedicineName.Equals(id))
        //        {
        //            c.MedicineRequirePrescription = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}
    }
}