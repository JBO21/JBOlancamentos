using System;

namespace JBO_Lancamentos
{
    public class Filmes : BaseId
    {
        private Generos Genero {get; set; }
        private string Titulo {get; set; }
        private string Descricao {get; set; }
        private int Ano {get; set; }
        private string Trailer {get; set; }
        private bool Excluido {get; set; }

        public Filmes (int id, Generos genero, string titulo, string descricao, int ano, string trailer)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Trailer = trailer;
            this.Excluido = false;

        }

        public override string ToString()
        {
            string result = "";
            result += "Gênero: " + this.Genero + Environment.NewLine;
            result += "Título: " + this.Titulo + Environment.NewLine;
            result += "Descricao: " + this.Descricao + Environment.NewLine;
            result += "Ano: " + this.Ano + Environment.NewLine;
            result += "Trailer: " + this.Trailer + Environment.NewLine;
            result += "Exluido: " + this.Excluido;

            return result;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;            
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }

    

}