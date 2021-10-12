using OrientacaoObjetos.ContextoCompartilhado;
using OrientacaoObjetos.ContextoNotificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class CarreiraItem : Base
    {
        public CarreiraItem(int ordem, string titulo, string descricao, Curso curso) 
        {
            if (curso == null)
                AddNotificacao(new Notificacao("Curso", "Curso inválido"));
                
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }
        public int Ordem { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public Curso Curso { get; private set; }
        
        


    }
}
