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


        public Ticket OpenTicket()
        {
            Ticket neuesTicket = Ticket.CreateFromInput(this);
            tickets.Add(neuesTicket);
            return neuesTicket;
        }

        public override string GetInfo()
        {   
            string baseInfo = base.GetInfo();
            return $"{baseInfo} , Email: {Email}, Telefonnummer: {Phonenumber}, Adresse: {Adresse}";
        }

    }
}
