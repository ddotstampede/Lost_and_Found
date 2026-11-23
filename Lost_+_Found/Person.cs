using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public abstract class Person
    {
        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string Name { get; set; }
        private int Age { get; set; }


        public virtual string GetInfo()
        {
            return $"Name: {Name}, Alter: {Age}";
        }
    }
}
