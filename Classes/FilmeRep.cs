using System;
using System.Collections.Generic;
using JBO_Lancamentos.Interfaces;

namespace JBO_Lancamentos
{
    public class FilmeRep : IRep<Filmes>
    {
        private List<Filmes> listaFilme = new List<Filmes>();
        public void Atualiza(int id, Filmes entidade)
        {
            listaFilme[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaFilme[id].Excluir();
        }

        public void Insere(Filmes entidade)
        {
            listaFilme.Add(entidade);
        }

        public List<Filmes> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filmes RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}