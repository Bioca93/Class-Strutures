using NovaClasseStruture;
using System;
using System.Collections.Generic;
using System.Xml.Linq;


Client client = new Client();
List<Client> clientList = new List<Client>();

int opcao;


Console.WriteLine("Bem-Vindo a Ficha de Utilizador");

do
{
    Console.WriteLine("Deseja aceder a ficha de: ");
    Console.WriteLine("1-Cliente");
    Console.WriteLine("2-Empregado");
    Console.WriteLine("3-Empresa");
    Console.WriteLine("0 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1: // CLIENTE

            Client.MenuCLient();
            break;

        case 2: // EMPREGADO

            Console.WriteLine("O que pretende fazer?");
            Console.WriteLine("1 - Adicionar um novo empregado.");
            Console.WriteLine("2 - Atualizar dados da ficha do empregado.");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero == 1)
            {

            }
            if (numero == 2)
            {
                Console.WriteLine("Que dados deseja atualizar?");
                Console.WriteLine("1 - Salário.");
                Console.WriteLine("2 - Departamento.");
                Console.WriteLine("3 - Função.");
                Console.WriteLine("4 - Detalhes do emprego.");
                int empregado = Convert.ToInt32(Console.ReadLine());
                if (empregado == 1)
                {
                    Console.WriteLine("Introduza o ID do cliente:");
                    int id = Convert.ToInt32(Console.ReadLine());

                }
                if (empregado == 2)
                {
                    Console.WriteLine("Introduza o ID do cliente:");
                    int id = Convert.ToInt32(Console.ReadLine());

                }
                if (empregado == 3)
                {
                    Console.WriteLine("Introduza o ID do cliente:");
                    int id = Convert.ToInt32(Console.ReadLine());
                }
                if (empregado == 4)
                {
                    Console.WriteLine("Introduza o ID do cliente:");
                    int id = Convert.ToInt32(Console.ReadLine());

                }
            }
            break;
        case 3: // EMPRESA
            Console.WriteLine("O que pretende fazer?");
            Console.WriteLine("1 - Aceder ao Provider Contact.");
            Console.WriteLine("2 - Adicionar morada empresa.");
            Console.WriteLine("3 - Mostrar detalhes da empresa.");
            int tarefa = Convert.ToInt32(Console.ReadLine());
            if (tarefa == 1)
            {
                Console.WriteLine("1- Adicionar Provider Contact.");
                Console.WriteLine("2- Atualizar o Provider Contact.");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {

                }
                if (option == 2)
                {

                }

            }
            if (tarefa == 2)
            {

            }
            if (tarefa == 3)
            {

            }
            break;
        case 0:
            break;

    }
} while (opcao != 0);
