using OrientacaoObjetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContextoAssinatura
{
    class Estudante : Base
    {
        public Estudante()
        {
            Assinaturas = new List<Assinatura>(); 
        }

        public string Nome { get; private set; }
        public string Email { get; private set; }
        public Usuario Usuario { get; private set; }

        public IList<Assinatura> Assinaturas { get; private set; }

        public bool EHpremio => Assinaturas.Any(x => !x.EstaInativo);


    }
}
