namespace GasStationPharmacyWS.Models
{
    /// <summary>
    /// Clase Medicina
    /// </summary>
    public class Medicine
    {
        public string MedicineName { get; set; }
        public string MedicineRequirePrescription { get; set; }
        public int MedicineQuantity { get; set; }
        public int MedicinePrice { get; set; }
        public string MedicinePH { get; set; }
    }
}