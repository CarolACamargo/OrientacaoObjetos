using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    class CarreiraItem
    {
        public CarreiraItem(IList<CarreiraItem> itens ,int ordem, string descricao, Curso curso, int quantidadeCursos )
        {
            Itens = new List<CarreiraItem>();
            Ordem = ordem;
            Descricao = descricao;
            Curso = curso;
        }
        public IList<CarreiraItem> Itens { get; set; }
        public int Ordem { get; private set; }
        public string Descricao { get; private set; }
        public Curso Curso { get; private set; }
        public int QuantidadeCursos => Itens.Count;
        


    }
}
