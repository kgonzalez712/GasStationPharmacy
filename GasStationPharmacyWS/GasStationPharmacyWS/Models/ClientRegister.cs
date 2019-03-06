using System;
using System.Collections.Generic;
using System.Linq;

namespace GasStationPharmacyWS.Models
{
    public class ClientRegister
    {
        public static List<Client> clientListB;
        public static List<Client> clientListP;
        private static ClientRegister clientReg;
        

        private ClientRegister()
        {
            clientListB = new List<Client>();
            clientListP = new List<Client>();
            var a = new Client();
            var b = new Client();
            a.ClientId = 345;
            a.ClientFirstName = "lala";
            a.ClientLastName = "lele";
            a.ClientBirthday = DateTime.Parse("07/23/1890");
            a.ClientAddress = "huehue";
            a.ClientAdditionalInformation = "Tuberculosis";
            a.ClientAccountPassword = "123344";
            a.ClientAccountEmail = "prueba@email.com";
            a.ClientPhoneNumber = 7894566;


            b.ClientId = 3444;
            b.ClientFirstName = "lolo";
            b.ClientLastName = "lulu";
            b.ClientBirthday = DateTime.Parse("07/11/1890");
            b.ClientAddress = "huue";
            b.ClientAdditionalInformation = "Tuberculosis b";
            b.ClientAccountPassword = "123344";
            b.ClientAccountEmail = "prueba@email.com";
            b.ClientPhoneNumber = 789456;

            clientListB.Add(a);
            //Console.WriteLine(a.ToString());
            clientListB.Add(b);
            clientListP.Add(b);
            clientListP.Add(a);


        }

        /// <summary>
        /// Maneja una sola instancia de cliente para tratar las adicionies, modificaciones y eliminaciones de clase con cada llamado del controlador
        /// </summary>
        /// <returns></returns>
        public static ClientRegister GetInstance()
        {
            if (clientReg == null)
            {
                clientReg = new ClientRegister();
                return clientReg;
            }

            return clientReg;
        }

        //----------------------------------------- Phischel & BombaTica ----------------------------------------------------------------//


        /// <summary>
        /// retorna los clientes para las dos farmacias
        /// </summary>
        /// <returns> Una Lista de clientes </returns>
        public List<Client> GetAllClients(List<Client> list)
        {
            return list;
        }


        /// <summary>
        /// retorna un cliente para las dos farmacias
        /// </summary>
        /// <returns> Un cliente </returns>
        public Client GetClient(List<Client> list, long id)
        {
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.ClientId.Equals(id)) return c;
            }

            return null;
        }


        /// <summary>
        /// Añade clientes para las dos farmacias
        /// </summary>
        /// <returns> false si no se crea, true si se crea </returns>
        public void AddClient(List<Client> list, Client client)
        {
            list.Add(client);
            //Console.WriteLine(client.ToString());
            //DataManager.GetInstance().WriteFileClients(list);
        }

        /// <summary>
        /// elimina clientes para las dos farmacias
        /// </summary>
        /// <returns> false si no lo elimina, true si lo elimina </returns>
        public bool RemoveClient(List<Client> list, long id)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.ClientId.Equals(id))
                {
                    list.RemoveAt(i);
                    action = true;
                    return action;
                }
            }

            return action;
        }

        /// <summary>
        /// modifica clientes para las dos farmacias
        /// </summary>
        /// <returns> false si no lo modifica, true si lo modifica </returns>
        public bool UpdateClient(List<Client> list, long id, Client value)
        {
            var action = false;
            for (var i = 0; i < list.Count(); i++)
            {
                var c = list.ElementAt(i);
                if (c.ClientId.Equals(id))
                {
                    list.RemoveAt(i);
                    list.Add(value);
                    action = true;
                    return action;
                }
            }

            return action;
        }
        //public bool UpdateClientFN(List<Client> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientFirstName = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientLN(List<Client> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientLastName = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientAD(List<Client> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientAddress = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientAI(List<Client> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientAdditionalInformation = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientAE(List<Client> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientAccountEmail = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientAP(List<Client> list, long id, string value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientAccountPassword = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientB(List<Client> list, long id, DateTime value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientBirthday = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}

        //public bool UpdateClientPN(List<Client> list, long id, int value)
        //{
        //    var action = false;
        //    for (var i = 0; i < list.Count(); i++)
        //    {
        //        var c = list.ElementAt(i);
        //        if (c.ClientId.Equals(id))
        //        {
        //            c.ClientPhoneNumber = value;
        //            action = true;
        //            return action;
        //        }
        //    }

        //    return action;
        //}
    }
}