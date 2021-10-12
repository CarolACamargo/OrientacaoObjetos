using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.ContextoNotificacao
{

    public abstract class Notificavel
    {
        public List<Notificacao> Notificacoes { get; private set; }

        public Notificavel()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AddNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
        public bool EhINValido => Notificacoes.Any();
       
    }
}
