using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18_PropriedadesIndexadas
{
    public class Produtos
    {
        public List<string> _itens;

        public Produtos()
        {
            this._itens = new List<string>();
        }
        
        public void Add(string item)
        {
            this._itens.Add(item);
        }
        
        public string Get(int index)
        {
            return this._itens[index];
        }

        //propriedade indexada
        public string this [int index]
        {
            get
            {
                //return this.Get(index);
                return this._itens[index];
            }

        }

        public int this [string nome]
        {
            get
            {
                return this._itens.IndexOf(nome) + 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prods = new Produtos();
            prods.Add("IPhone");
            prods.Add("IPad");
            prods.Add("Ipod");

            
            for (int i = 0; i <= 2; i++)
                Console.WriteLine(prods.Get(i));

            for (int i = 0; i <= 2; i++)
                Console.WriteLine(prods[i]);

            Console.WriteLine("A posição do item IPad é " + prods["IPad"]);
            Console.ReadKey();
            
        }
    }
}
