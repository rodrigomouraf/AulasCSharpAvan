using System;

namespace Aula7_Propriedades
{
    public class MensalidadeNegativaException: Exception
    {
        public MensalidadeNegativaException(string message):
            base(message)
        {

        }
    }

    public enum TipoAluno
    {
        Regular, Especial
    }

    public class Aluno
    {
        private int _matricula;
        private double _mensalidade;
        private string _nome;
        private TipoAluno _tipo;

        public int Matricula
        {
            get { return this._matricula;  }
            set { this._matricula = value; }
        }

        public string Nome { get { return _nome; } set { _nome = value; } }

        public double Mensalidade
        {
            get { return _mensalidade; }
            set {
                if (value < 0)
                    throw new MensalidadeNegativaException("Valor da mensalidade não pode ser negativo");
                else
                    _mensalidade = value;
            }
        }

        public TipoAluno Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Aluno a = new Aluno();
            a.Matricula = 123;
            a.Mensalidade = -100;
            a.Tipo = TipoAluno.Regular;
            }
            catch(MensalidadeNegativaException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
 