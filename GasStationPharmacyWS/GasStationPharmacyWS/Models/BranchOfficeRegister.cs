using System.Collections.Generic;
using System.Linq;

namespace GasStationPharmacyWS.Models
{
    public class BranchOfficeRegister
    {
        public static List<BranchOffice> branchListB;
        public static List<BranchOffice> branchListP;
        private static BranchOfficeRegister branchReg;


        private BranchOfficeRegister()
        {
            branchListB = new List<BranchOffice>();
            branchListP = new List<BranchOffice>();

            var a = new BranchOffice();
            a.BranchOfficeAddress = "Cartago, Los Angeles";
            a.BranchOfficeAdminName = "Carlos Araya";
            a.BranchOfficeName = "Phischel #1";
            a.BranchOfficeDescription = "nada";

            var b = new BranchOffice();
            b.BranchOfficeAddress = "Cartago";
            b.BranchOfficeAdminName = "Juanito el huerfanito";
            b.BranchOfficeName = "BombaTica #1";
            a.BranchOfficeDescription = "nada";

            branchListB.Add(b);
            branchListP.Add(a);
        }


        public static BranchOfficeRegister GetInstance()
        {
            if (branchReg == null)
            {
                branchReg = new BranchOfficeRegister();
                return branchReg;
            }

            return branchReg;
        }


        public List<BranchOffice> GetAllBranches(List<BranchOffice> list)
        {
            return list;
        }


        public BranchOffice GetBranch(List<BranchOffice> list, string name)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.BranchOfficeName.Equals(name)) return c;
            }

            return null;
        }

        public void AddBranchOffice(List<BranchOffice> list, BranchOffice branch)
        {
            list.Add(branch);
        }

        public bool RemoveBranchOffice(List<BranchOffice> list, string id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.BranchOfficeName.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }

        public bool UpdateBranchOffice(List<BranchOffice> list, string id, BranchOffice value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.BranchOfficeName.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }
            return action;
        }

        //public bool UpdateBranchOfficeN(List<BranchOffice> list, string id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.BranchOfficeName.Equals(id))
        //        {
        //            c.BranchOfficeName = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateBranchOfficeAD(List<BranchOffice> list, string id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.BranchOfficeName.Equals(id))
        //        {
        //            c.BranchOfficeAddress = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateBranchOfficeAN(List<BranchOffice> list, string id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.BranchOfficeName.Equals(id))
        //        {
        //            c.BranchOfficeAdminName = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}
    }
}