using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Xml.Linq;

namespace Lost___Found
{
    public class Customer : Person
    {
        //Todo variablen erweitern 


        public string Email { get; private set; }
        public string Phonenumber { get; private set; }
        public string Adresse { get; private set; }
        public List<Ticket> tickets { get; private set; } = new List<Ticket>();



        public Customer( string name, int age ,string email, string phonenumber, string adresse) : base(name, age)
        {
            
            Email = email;
            Phonenumber = phonenumber;
            Adresse = adresse;
        }


        //Todo methode ausarbeiten

        public Ticket OpenTicket(string type, string description)
        {
            Ticket neuesTicket = new Ticket(type, description, true, this, DateTime.Now);
            tickets.Add(neuesTicket);
            return neuesTicket;
        }

        public virtual string GetInfo()
        {   
            string baseInfo = base.GetInfo();
            return $"{baseInfo} , Email: {Email}, Telefonnummer: {Phonenumber}, Adresse: {Adresse}";
        }

    }
}
