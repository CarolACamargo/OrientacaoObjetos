using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public abstract class Conteudo
    {
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Url { get; private set; }

        public Conteudo(string titulo, string url)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Url = url;
        }
    }
}
