using System;
using System.Text;

namespace ValueRef
{
    public class Cliente: Object //Reference Type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Código: " + Codigo);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Telefone: " + Telefone);

            return sb.ToString();
        }
    }

    class Program
    {
     
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Codigo = 123;
            c1.Nome = "Rodrigo";
            c1.Telefone = "99877-2618";
            Cliente c2;
            //...
            c2 = c1; // aponta para a mesma posicao de memoria c1
            c2.Nome = "Stéphane";
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            if (c1.Equals(c2))
                Console.WriteLine("c1 e c2 são os mesmos objetos");
            else
                Console.WriteLine("c1 e c2 são objetos diferentes");
            //Console.WriteLine(c.Codigo);
            //Console.WriteLine(c.Nome);
            //Console.WriteLine(c.Telefone);
            
            Console.ReadKey();
        }

        private static void MostrarValueTypes()
        {
            int x;
            string s;
            bool b;

            x = 10;
            s = "Rodrigo";
            b = false;

            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }
    }
}
