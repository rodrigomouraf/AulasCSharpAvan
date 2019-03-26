using System;

namespace Aula_5_Construtores
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    //padrão
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        //overloads
        public Cliente(int codigo)
        {
            this.Codigo = codigo;
        }

        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + ", Nome: " + Nome;
        }
    }

    public class ClienteVIP : Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome)
            : base(codigo, nome) //chamando o contrutor da classe base
        {
            this.Tempo = 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Codigo = 123;
            cli1.Nome = "Rodrigo";
            cli1.Contato.Tipo = "Telefone";
            cli1.Contato.Descricao = "999999999";

            Cliente cli2 = new Cliente(456);
            cli2.Nome = "lalala";

            Cliente cli3 = new Cliente(789, "lelele");

            ClienteVIP cli4 = new ClienteVIP(159, "lilili");

            Console.WriteLine(cli1);
            Console.WriteLine(cli2);
            Console.WriteLine(cli3);
            Console.WriteLine(cli4);

            Console.ReadKey();
        }
    }
}

