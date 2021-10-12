using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContextoNotificacao
{
    public sealed class Notificacao
    {
        public Notificacao()
        {

        }

        public Notificacao(string propriedade, string mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string Propriedade { get; private set; }

        public string Mensagem { get; private set; }
    }
}
