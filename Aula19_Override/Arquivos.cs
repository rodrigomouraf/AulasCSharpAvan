using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19_Override
{
    public abstract class Arquivo
    {
        public string Nome;
        public int Tamanho;
        public virtual void Abrir()
        {
            Console.WriteLine("lalala");
        }
        
    }
    public class Musica : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Tocando música: " + Nome);
        }
    }
    public class DocumentoWord: Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando documento do Word: " + Nome);
        }
    }
    public class Imagem: Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando imagem: " + Nome);
        }
    }
    public class Windows
    {
        private List<Arquivo> _arquivos;

        public Windows()
        {
            this._arquivos = new List<Arquivo>();
        }
        public void Add(Arquivo arquivo)
        {
            this._arquivos.Add(arquivo);
        }
        public void Abrir(Arquivo arquivo)
        {
            arquivo.Abrir();
        }
    }
}