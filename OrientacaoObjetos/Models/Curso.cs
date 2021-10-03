using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Curso : Conteudo
    {
        public Curso(string titulo, string url, string tag, IList<Modulo> modulos) : base(titulo, url)
        {
            Tag = tag;
            Modulos = modulos ?? new List<Modulo>(); 
        }

        public string Tag { get; private set; }

        public IList<Modulo> Modulos { get; private set; }
    }

}
