using System;

namespace GasStationPharmacyWS.Models
{
    public class Admin
    {
        public long AdminId { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public DateTime AdminBirthday { get; set; }
        public string AdminAddress { get; set; }
        public string AdminAccountEmail { get; set; }
        public string AdminAccountPassword { get; set; }
    }
}