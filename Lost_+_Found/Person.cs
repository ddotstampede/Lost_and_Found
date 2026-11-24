using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public abstract class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }


        public virtual string GetInfo()
        {
            return $"Name: {Name}, Alter: {Age}";
        }
    }
}
