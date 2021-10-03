using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url, int  quantidadeCursos) : base(titulo, url)
        {
            QuantidadeCursos = quantidadeCursos;
        }

        public int QuantidadeCursos { get; private set; }
    }
}
