using OrientacaoObjetos.ContextoCompartilhado;
using OrientacaoObjetos.ContextoNotificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Modulo : Base
    {
        public int Ordem { get; private set; }
        public string Titulo { get; private set; }
        public IList<Aula> Aulas { get; private set; }

        public Modulo(int ordem, string titulo, IList<Aula> aulas)
        {
            Ordem = ordem;
            Titulo = titulo;
            Aulas = aulas;
        }
    }
    
}
