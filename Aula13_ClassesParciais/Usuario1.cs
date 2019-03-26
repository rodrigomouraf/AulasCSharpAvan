using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Usuario
{
    public int Codigo;
    public string Nome;
    public string Senha;
    public Usuario(int codigo, string nome, string senha)
    {
        this.Codigo = codigo;
        this.Nome = nome;
        this.Senha = senha;
    }
}

