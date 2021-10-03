using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Carreira : Conteudo
    {
        public Carreira(
            string titulo, 
            string url, 
            IList<CarreiraItem> itens)
            : base(titulo, url)
        {
            Itens = itens;
            TotalCursos = itens.Count();
        }

        public int QuantidadeCursos { get; private set; }
        public IList<CarreiraItem> Itens { get; private set; }
        public int TotalCursos { get; private set; }

        
    }
}
