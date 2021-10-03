using OrientacaoObjetos.Models;
using System;
using System.Collections.Generic;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulasPrimeiroModulo = new List<Aula> 
            {
                new Aula(1, "Aula 1", 5),
                new Aula(2, "Aula 2", 3),
                new Aula(3, "Aula 3", 1),
                new Aula(4, "Aula 4", 200),
            };

            var aulasSegundoModulo = new List<Aula>
            {
                new Aula(1, "Aula 1", 1),
                new Aula(2, "Aula 2", 2),
                new Aula(3, "Aula 3", 5),
                new Aula(4, "Aula 4", 2),
            };

            var modulos = new List<Modulo>
            {
                new Modulo(1, "mod1", aulasPrimeiroModulo),
                new Modulo(2, "mod1", aulasSegundoModulo),
            };

            var curso = new Curso("Curso tal", "blabla", "tag x", modulos, Enums.ENivelCurso.Basico);
            Console.WriteLine(curso.DuracaoEmMinutos);

            var itensCarreira = new List<CarreiraItem>();
            var carreira = new Carreira("borgesCurso", "", itensCarreira);

        }
    }
}
