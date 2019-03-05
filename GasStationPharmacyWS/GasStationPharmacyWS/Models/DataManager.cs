using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace GasStationPharmacyWS.Models
{
    public  class DataManager
    {
        private static DataManager manager;

        public static StreamWriter fileClientsP =
            new System.IO.StreamWriter(
                @"C:\Users\kevgo\source\repos\GasStationPharmacyWS\Clients\PhischelClients.txt");
        public string[] lines = { "First line", "Second line", "Third line" };

        public static DataManager GetInstance()
        {
            if (manager == null)
            {
                manager = new DataManager();
                return manager;
            }

            return manager;
        }


        public void WriteFileClients(List<Client> list)
        {

            foreach (string line in lines)
            {
                 fileClientsP.WriteLine(line);
            }

        }

    }
}