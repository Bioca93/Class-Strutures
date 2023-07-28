using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NovaClasseStruture
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public int DoorNumber { get; set; }
        public int Floor { get; set; }
        public int PostalCode { get; set; }
        public string Locale { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        //public Address()
        //{ }
        //public Address (string street, int doorNumber, int floor, int postalCode, string locale, string city, string country)
        //{
        //    Street = street;
        //    DoorNumber = doorNumber; 
        //    Floor = floor;
        //    PostalCode = postalCode;
        //    Locale = locale;
        //    City = city;
        //    Country = country;
        
        //}

      
        //public string GetAddress(Address address)
        //{
        //int id = 1;

        //    foreach (Address cliente in _addresses)
        //    {
        //        if (cliente.Id >= id)
        //            id = cliente.Id + 1;
        //    }
        //    address.Id = id;
        //    _addresses.Add(address);

        //  foreach (Address cliente in _addresses)
        //        if (cliente.Id == id)
        //        {
        //            Console.WriteLine(cliente.SetAddress());
        //        }

        //  return $"Address: {address}";


        //}

        //public void SetAddress()
        //{
        //    List<Address> addresses = new(Street, DoorNumber, Floor, PostalCode, Locale, City, Country);

        //    Console.WriteLine("Qual o nome da rua?");
        //    Street = Console.ReadLine();
        //    Console.WriteLine("Qual o número da porta?");
        //    DoorNumber = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Qual o andar?");
        //    Floor = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Qual o código postal?");
        //    PostalCode = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Qual a localidade?");
        //   Locale = Console.ReadLine();
        //    Console.WriteLine("Qual a cidade?");
        //    City = Console.ReadLine();
        //    Console.WriteLine("Qual o país?");
        //    Country = Console.ReadLine();

           
        //    addresses.Add(address);

        //    static void Main(string[] args)
        //    {
        //        //Declaração da lista
        //        List<string> lista = new List<string>();

        //        string opcao = "1";

        //        while (opcao == "1")
        //        {
        //            Console.WriteLine("Digite um nome para inserir na lista:");
        //            string nome = Console.ReadLine();
        //            //Adiciona o item à lista
        //            lista.Add(nome);
        //            Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
        //            opcao = Console.ReadLine();
        //        }
            


        //    Read more: http://www.linhadecodigo.com.br/artigo/3676/listt-trabalhando-com-listas-genericas-em-csharp.aspx#ixzz7pBMGiocq


        //    List<Person> persons = new List<Person>
        //    {
        //        new Person { FirstName = "Mahesh Chand", LastName = "Graphics with GDI+", PhoneNumber = 4995 , Email ="gdek@gmns"},
        //        new Person { FirstName = "Mahesh Chand",  LastName = "Mastering C#", PhoneNumber = 5495, Email ="gd@gmns" },
        //        new Person { FirstName = "Mahesh Chand", LastName = "Jumpstart Blockchain", PhoneNumber = 4495, Email = "ek@gmns" }
        //    };

        //    persons.Add(new Person { FirstName = "dhagw", LastName = "1231", PhoneNumber = 123, Email = "awud" });

            

        //    foreach (Person person in persons)
        //    {
        //        Console.WriteLine($"Person: {person.FirstName}:{person.LastName}:{person.PhoneNumber}:{person.Email}");
        //    }

    //    }
    }
}
