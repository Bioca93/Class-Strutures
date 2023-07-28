using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NovaClasseStruture
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sector { get; set; }
        public int Nif { get; set; }
        public string DeliveryAddress { get; set; }
        public int PhoneNumber { get; set; }

        public string Email { get; set; }

       public static List<Client> Clients = new List<Client>();

        public Client()
        {
            int id = Id;
            string name = Name;
            string address = Address;
            string sector = Sector;
            int nif = Nif;
            string deliveryAddress = DeliveryAddress;
            int phoneNumber = PhoneNumber;
            string email = Email;
        }

        public static List<Client> AddClient(List<Client> clients, int id, string name, string address, string sector, int nif, string deliveryAddress, int phoneNumber, string email)
        {
           
            Client client = new Client();

            client.Id = id;
            client.Name = name;
            client.Address = address;
            client.Sector = sector;
            client.Nif = nif;
            client.DeliveryAddress = deliveryAddress;
            client.PhoneNumber = phoneNumber;
            client.Email = email;

            Clients.Add(client);

            return Clients;

        }

        public static void AddNewClient()
        {
          

            int id = 1; 
            Console.WriteLine("Introduza o nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Introduza a morada: ");
            string address = Console.ReadLine();
            Console.WriteLine("Introduza o setor: ");
            string sector = Console.ReadLine();
            Console.WriteLine("Introduza o NIF: ");
            int nif = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza a morada de entrega: ");
            string deliveryAddress = Console.ReadLine();
            Console.WriteLine("Introduza o contacto telefónico: ");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza o e-mail: ");
            string email = Console.ReadLine();

          Clients = AddClient(Clients, id, name, address, sector, nif, deliveryAddress, phoneNumber, email);
        }

        public static List<Client> AddClientAddress(List<Client> Clients)
        {
           // Client client = new Client();

            int id = 0;

            Console.WriteLine("Introduza o ID do cliente: ");
            id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Introduza a morada: ");
            string address = Console.ReadLine();

            foreach (Client client in Clients)
            {
                if (client.Id == id)
                    client.Address = address;
            }

            return Clients;
        }



        public static List<Client> UpdateClientAddress(List<Client> Clients)
        {
            Client client = new Client();
            int id=0;

            Console.WriteLine("Introduza o ID do cliente: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduza a morada atual: ");
            string updateAddress = Console.ReadLine();

            foreach (Client clients in Clients)
            {
                if (client.Id == id)
                {
                    client.Address = updateAddress;
                }
            }

            return Clients;
        }

        public static void GetClients(List<Client> clientList)
        {
            int id = 1;

            foreach (Client client in clientList)
            {
                if (client.Id >= id)
                    id = client.Id + 1;

                Console.WriteLine("ID: " + client.Id);
                Console.WriteLine("Name: " + client.Name);
                Console.WriteLine("Address: " + client.Address);
                Console.WriteLine("Sector: " + client.Sector);
                Console.WriteLine("NIF: " + client.Nif);
                Console.WriteLine("Delivery Address: " + client.DeliveryAddress);
                Console.WriteLine("Phone Number: " + client.PhoneNumber);
                Console.WriteLine("Email: " + client.Email);
            }

        }


        public static void MenuCLient()
        {
            int opcao;
            do
            {
                Console.WriteLine("1- Introduzir um novo cliente.");
                Console.WriteLine("2 - Adicionar morado do cliente.");
                Console.WriteLine("3 - Atualizar morada do cliente.");
                Console.WriteLine("4 - Ver clientes.");
                Console.WriteLine("0 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AddNewClient();

                        break;
                    case 2:
                        AddClientAddress(Clients);
                        break;
                    case 3:
                        UpdateClientAddress(Clients);
                        break;
                    case 4:
                        GetClients(Clients);
                        break;
                }

            } while (opcao != 0);
        }
        


    }
}
