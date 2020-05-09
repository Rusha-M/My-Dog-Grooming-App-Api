using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogGroomingApiF.Models
{
    public class Service
    {
        public String Code { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }// euro
        public int NoOfDogs { get; set; }
        public int ClientID { get; set; }
    }
}