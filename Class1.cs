using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios
{
    public abstract class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
    }

    

    public class Customer : Person
    {
        public DateTime Registration;
        private int CreditScore;
    }
    
    public class Employee : Person
    {
        public enum Department;
        public float Salary;
    }
}
