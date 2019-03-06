using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    /// <summary>
    /// Clase Cliente
    /// </summary>
    public class Client
    {
        public long ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public DateTime ClientBirthday { get; set; }
        public string ClientAddress { get; set; }
        public string ClientAdditionalInformation { get; set; }
        public int ClientPhoneNumber { get; set; }
        public string ClientAccountEmail { get; set; }
        public string ClientAccountPassword { get; set; }
    }
}