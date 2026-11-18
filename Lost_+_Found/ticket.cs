using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class ticket
    {

        private int id;
        private string name;
        private string description;

        public ticket(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;

        }

        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Id { get { return id; } set { id = value; } }
        //Todo methode ausarbeiten
        public void OpenTicket()
        {

        }
    


}
   
}
