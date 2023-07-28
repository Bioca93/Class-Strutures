using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace NovaClasseStruture
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        // public string Address { get; set; }

        private List <Address> _addresses= new List <Address> ();

        private List<Person> _persons = new List<Person>();

        public string GetAddress(Address address)
        {
            
            _addresses.Add (address);

            return $"Address: {address}";


    }

        public string GetFullName(Person person)
        {

            string firstName = FirstName;
            string lastName = LastName;
            string fullName = firstName + lastName;

            return $"Nome completo:{fullName}";
        }


        public string GetContacts()
        {

            return $"Phone Number: {PhoneNumber}";
        }

        public string SetNewPerson(Person person)
        {

            Console.WriteLine("Qual o seu primeiro nome?");
            FirstName = Console.ReadLine();
            Console.WriteLine("Qual o seu ultimo nome?");
            LastName = Console.ReadLine();

            Console.WriteLine("Qual o seu contacto?");
            PhoneNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o seu e-mail?");
            Email = Console.ReadLine();

            
            _persons.Add(person);

            return $"First Name:{FirstName}, Last Name: {LastName}, Phone Number: {PhoneNumber}, Email: {Email}";


        }
        
    }
}
