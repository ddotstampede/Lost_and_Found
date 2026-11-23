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

        
        private string Email { get; set; }
        private string Phonenumber { get; set; }
        private string Adresse { get; set; }    
        
       

        public Customer( string name, int age ,string email, string phonenumber, string adresse) : base(name, age)
        {
            
            Email = email;
            Phonenumber = phonenumber;
            Adresse = adresse;
        }


        //Todo methode ausarbeiten
        public virtual string GetInfo()
        {   
            string baseInfo = base.GetInfo();
            return $"{baseInfo} , Email: {Email}, Telefonnummer: {Phonenumber}, Adresse: {Adresse}";
        }
    }
}
