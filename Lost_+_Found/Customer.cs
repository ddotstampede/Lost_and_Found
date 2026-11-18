using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Customer
    {
        //Todo variablen erweitern 

        private string name;
        private string email;
        private string phonenumber;
        private string adresse;
        
       

        public Customer(string name, string email, string phonenumber, string adresse)
        {
            Name = name;
            Email = email;
            Phonenumber = phonenumber;
            Adresse = adresse;
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        } 
        public string Email
        {
            get { return email; }
            set {  email = value; }

        }
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        public string Adresse
        {
            get{ return adresse; }
            set{ adresse = value; }
        }
        //Todo methode ausarbeiten
        public void AddCustomer()
        {
            
        }
    }
}
