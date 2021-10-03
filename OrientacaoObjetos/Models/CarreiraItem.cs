using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class CarreiraItem
    {
        public int Ordem { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public Curso Curso { get; private set; }
    }

}
