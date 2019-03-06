using System;

namespace GasStationPharmacyWS.Models
{
    /// <summary>
    /// Clase Doctor
    /// </summary>
    public class Doctor
    {
        public long DoctorId { get; set; }
        public long DoctorDid { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public DateTime DoctorBirthday { get; set; }
        public string DoctorAddress { get; set; }
        public string AccountPassword { get; set; }
    }
}