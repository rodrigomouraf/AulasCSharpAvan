using System;

namespace Aula6_GetSet
{
    public class Conta
    {
        private string _cliente;
        private double _valor;
        public Conta(string nomeCliente)
        {
            this._cliente = nomeCliente;
        }

        public Conta()
        {
            
        }

        public string getCliente()
        {
            return this._cliente;
        }

        public void setCliente(string value)
        {
            this._cliente = value;
        }

        public void Sacar(double valor)
        {
            this._valor = this._valor - valor;
        }

        public void Depositar(double valor)
        {
            this._valor = this._valor + valor;
        }

        public double getValor()
        {
            return this._valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Conta c = new Conta("Rodrigo"); -- Após fazer o método set do Cliente e criar um overload.
            Conta c = new Conta();
            c.setCliente("Rodrigo");
            c.Depositar(109);

            Console.WriteLine(c.getValor());

            c.Sacar(50);

            Console.WriteLine("Nome CLiente: " + c.getCliente() + ", Valor conta: " + c.getValor());

            Console.ReadKey();
        }
    }
}
