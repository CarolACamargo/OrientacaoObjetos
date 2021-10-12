using OrientacaoObjetos.ContextoCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContextoAssinatura
{
    class Assinatura : Base
    {
        public Plano Plano { get; private set; }

        public DateTime? EndDate { get;  private set; }

        public bool EstaInativo => EndDate <= DateTime.Now;
    }
}
