using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Usuario
{
    public bool Autenticar()
    {
        return ((Nome == "Rodrigo") & (Senha == "senha"));
    }
}

