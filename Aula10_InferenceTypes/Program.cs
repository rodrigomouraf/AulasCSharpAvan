using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10_InferenceTypes
{
    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }
    }

    public static class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //linkar com objetos que só vai reconhecer em tempo de execução
            dynamic con = Fabrica.CriarConnection();
            con.ConnectionString = "Banco";
            con.Conectar(10);
            con.Fechar();
            Console.ReadLine();
        }

        private static void Algum1()
        {
            Connection con = Fabrica.CriarConnection();
            //Connection con = new Connection() { ConnectionString = "BANCO" };
            //var con = new Connection() { ConnectionString = "BANCO" };
            con.Conectar();
            con.Fechar();
        }
    }
}
