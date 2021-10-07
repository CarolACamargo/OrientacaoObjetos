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
            artigos.Add(new Artigo("blavblaba", " "));
            artigos.Add(new Artigo("lalalal", " "));

            foreach (var artigo in artigos)
            {
                Console.WriteLine(artigo.Titulo);
            }
        }

    }
}
