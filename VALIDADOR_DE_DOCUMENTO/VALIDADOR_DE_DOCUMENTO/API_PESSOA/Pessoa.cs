using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_PESSOA
{
    public abstract class Pessoa
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }

        public Pessoa (long Codigo, string Nome)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
        }

        public abstract string Imprimir();
        public abstract bool Validar();
    }
}
