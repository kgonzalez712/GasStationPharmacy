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

        public static MedicineRegister GetInstance()
        {
            if (medReg == null)
            {
                medReg = new MedicineRegister();
                return medReg;
            }

            return medReg;
        }

        public List<Medicine> GetAllMedicines(List<Medicine> list)
        {
            return list;
        }

        public Medicine GetMedicine(List<Medicine> list, string name)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.MedicineName.Equals(name)) return c;
            }

            return null;
        }

        public void AddMedicine(List<Medicine> list, Medicine med)
        {
            list.Add(med);
        }

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