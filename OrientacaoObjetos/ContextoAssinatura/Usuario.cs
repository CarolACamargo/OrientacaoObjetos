using OrientacaoObjetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContextoAssinatura
{
    class Usuario : Base
    {
        public string Nome { get; private set; }

        public string Senha { get; private set; }
    }
}
