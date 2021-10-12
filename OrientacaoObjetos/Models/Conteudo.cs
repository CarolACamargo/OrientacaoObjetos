using OrientacaoObjetos.ContextoCompartilhado;
using OrientacaoObjetos.ContextoNotificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public abstract class Conteudo : Base
    {
       
        public string Titulo { get; private set; }
        public string Url { get; private set; }

        public Conteudo(string titulo, string url)
        {
            
            Titulo = titulo;
            Url = url;
        }
    }
}
