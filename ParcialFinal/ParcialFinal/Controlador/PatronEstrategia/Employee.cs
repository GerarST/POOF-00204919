using System;
using System.Collections.Generic;

namespace ParcialFinal.Controlador
{
    public class Employee : User
    {
        public Employee(string card, string name, string lastName, string password, string dui, string dateBirth) : base(card, name, lastName, password, dui, dateBirth)
        {
        }

        public bool Coming()
        {
            throw new NotImplementedException();
        }

        public bool Leaving()
        {
            throw new NotImplementedException();
        }
    }
}