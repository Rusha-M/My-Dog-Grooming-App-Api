using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogGroomingApiF.Models
{
    public class Client
    {
        // randomly generated client ID
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string DogName { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public List<Service> Services { get; set; } = new List<Service>();
    }
}