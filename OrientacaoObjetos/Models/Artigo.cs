using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Artigo : Conteudo
    {
        public Artigo(string titulo, string url) : base(titulo, url)
        {
        }
       
    }
}
