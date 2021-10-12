using OrientacaoObjetos.ContextoNotificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContextoCompartilhado

{
    public abstract class Base : Notificavel
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}
