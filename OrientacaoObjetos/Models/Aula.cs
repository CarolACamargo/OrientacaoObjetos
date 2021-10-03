using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Aula
    {
        public int Ordem { get; private set; }
        public string Titulo { get; private set; }

        public Aula(int ordem, string titulo)
        {
            Ordem = ordem;
            Titulo = titulo;
        }
    }
}
