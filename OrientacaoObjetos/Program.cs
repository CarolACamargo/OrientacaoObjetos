using OrientacaoObjetos.Models;
using System;
using System.Collections.Generic;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            var artigos = new List<Artigo>();
            artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-obj"));
            artigos.Add(new Artigo("Artigo sobre c#", "c-sharp"));
            artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

            foreach (var artigo in artigos)
            {
                Console.WriteLine(artigo.Id);
                Console.WriteLine(artigo.Titulo);
                Console.WriteLine(artigo.Url);
            }

            var cursoCsharp = new Curso("Fundamentos C#", "fundamentos-sharp", " ", 1, new List<Modulo>());
            var cursoFlutter = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet", " ", 2, new List<Modulo>());
            var curso = new Curso("Fundamentos OOP", "fundamentos-oop", " ", 3, new List<Modulo>());
           
            var cursos = new List<Curso> {
                curso,
                cursoCsharp,
                cursoFlutter,
            };

            var carreiraItensDotNet = new List<CarreiraItem>
            {
                 new CarreiraItem(1,"Comece por aqui", "", cursoCsharp),
                 new CarreiraItem(2,"Aprenda C#", "", cursoCsharp),
                 new CarreiraItem(3,"Fundamentos C#", "", cursoCsharp),
            };

            var carreiraItensFlutter = new List<CarreiraItem>
            {
                 new CarreiraItem(1,"Especialista Flutter", "", cursoFlutter),
                 new CarreiraItem(2,"Aprenda Flutter", "", cursoFlutter),
                 new CarreiraItem(3,"bla", "", cursoFlutter),
            };
           
            var carreiraDotNet = new Carreira("Especialista .NET", "esppecialista-dotnet", carreiraItensDotNet);
            var carreiraFlutter = new Carreira("Dev Flutter", "dev-flutter", carreiraItensFlutter);

            var carreiras = new List<Carreira>
            {
                carreiraDotNet,
                carreiraFlutter
            };

            Console.Clear();
            foreach (var carreira in carreiras)
            {
                Console.WriteLine($"Carreira: {carreira.Titulo}");

                foreach (var carreiraItem in carreira.Itens)
                {
                    Console.WriteLine($"    CarreiraItem: {carreiraItem.Ordem}, {carreiraItem.Titulo}");
                    Console.WriteLine(carreiraItem.Curso?.Titulo);
                    Console.WriteLine(carreiraItem.Curso?.Nivel);

                    foreach (var notificacao in carreiraItem.Notificacoes)
                    {
                        Console.WriteLine($"{notificacao.Propriedade} -  {notificacao.Mensagem}");
                    }
                   
                }
            }

        }

    }
}
