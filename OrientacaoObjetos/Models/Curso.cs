using OrientacaoObjetos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    public class Curso : Conteudo
    {
        public Curso(string titulo, string url, string tag, IList<Modulo> modulos, ENivelCurso nivel)
            : base(titulo, url)
        {
            Tag = tag;
            Modulos = modulos ?? new List<Modulo>();
            DuracaoEmMinutos = CalcularMinutos();
            Nivel = nivel;
        }

        public string Tag { get; private set; }
        public IList<Modulo> Modulos { get; private set; }
        public int DuracaoEmMinutos { get; private set; }
        public ENivelCurso Nivel { get; private set; }

        private int CalcularMinutos()
        {
            var aulas = new List<Aula>();

            foreach (var modulo in Modulos)
            {
                aulas.AddRange(modulo.Aulas);
            }

            return aulas.Sum(x => x.Duracao);
        }

    }

}
