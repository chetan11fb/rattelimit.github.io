using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    internal class ContactInfo
    {
        public string address { get; set; }
        public string suiteAddress { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public string zipCode { get; set; }
        public Country country { get; set; }
        public string phone { get; set; }
        public string email { get; set; }


    }
    public class State
    {
        public string name { get; set; }
        public string abbreviation { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class City
    {
        public string name { get; set; }
        public string abbreviation { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public string abbreviation { get; set; }
    }
}