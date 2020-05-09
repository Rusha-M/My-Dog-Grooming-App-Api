using DogGroomingApiF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DogGroomingApiF.Controllers
{
    [RoutePrefix("api/Client")]
    public class ClientController : ApiController
    {
        List<Client> clients = new List<Client>();
        List<Service> serv = new List<Service>();
        ClientController() : base()
        {
            Client c1 = new Client() { ClientID = 1, Name = "John", DogName = "Max", Email = "john@gmail.com", Date = new DateTime(01 / 06 / 2020) };
            Client c2 = new Client() { ClientID = 2, Name = "Mary", DogName = "Nani", Email = "mary@yahoo.com", Date = new DateTime(11 / 05 / 2020) };
            clients.Add(c1);
            clients.Add(c2);

            Service S1 = new Service() { Code = "AA125", Description = "Wash and Dry", NoOfDogs = 1, Price = 20, ClientID = 2 };
            Service S2 = new Service() { Code = "CA124", Description = "WashCutDry", NoOfDogs = 1, Price = 25, ClientID =1 };
            serv.Add(S1);
            serv.Add(S2);
        }

        // GET: api/Client/1
        public List<Service> Get()
        {
            return serv;
        }

        // GET: api/Client/5
        public string GetById(int id)
        {
            var entries = clients.FirstOrDefault(p => p.ClientID == id);
            if (entries != null)
            {
                return entries.Name + " " + entries.Email + entries.DogName + entries.Date;
            }
            else
            {
                return " Client ID Not Found..";
            }
        }
    }
}
