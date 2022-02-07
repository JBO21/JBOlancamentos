using System;



namespace JBO_Lancamentos
{
    class Program
    {
        static FilmeRep rep = new FilmeRep();
        
        static void Main(string[] args)
        {
            string escolha = EscolhaUsuario();
            while (escolha.ToUpper() != "X")
            {
                switch(escolha)
                {
                    case "1":
                        ListaFilme();
                        break;
                    case "2":
                        InserirFilme();
                        break;
                    case "3":
                        AtualizaFilme();
                        break;
                    case "4":
                        ExcluirFilme();
                        break;
                    case "5":
                        VisualizarFilme();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                escolha = EscolhaUsuario();
                

            }

            System.Console.WriteLine("Obrigado! Volte Sempre!");
            Console.ReadLine();
           
        }
        private static void ListaFilme()
        {
            System.Console.WriteLine("Listar Filmes:");
            var lista = rep.Lista();
            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhum Filme cadastrado.");
                return;
            }
            foreach(var filme in lista)
            {
                var excluido = filme.retornaExcluido();

                System.Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluido*" : ""));
            }
        }

        private static void InserirFilme()
        {
            System.Console.WriteLine("Inserir novo Filme: ");
            foreach (int x in Enum.GetValues(typeof(Generos)))
            {
                System.Console.WriteLine("{0} - {1}", x, Enum.GetName(typeof(Generos), x));
            }
            System.Console.WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo do Filme:");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição do Filme:");
            string entradaDescricao = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do Trailer do Filme:");
            string entradaTrailer = Console.ReadLine();

            Filmes novoFilme = new Filmes(id: rep.ProximoId(), 
                                            genero: (Generos)entradaGenero, 
                                            titulo: entradaTitulo, ano: entradaAno, 
                                            descricao: entradaDescricao, 
                                            trailer: entradaTrailer);
            
            rep.Insere(novoFilme);

        }

        private static void AtualizaFilme()
        {
            System.Console.WriteLine("Digite o ID do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            foreach(int x in Enum.GetValues(typeof(Generos)))
            {
                System.Console.WriteLine("{0} - {1}", x, Enum.GetName(typeof(Generos), x));
            }
            System.Console.WriteLine("Digite o Gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Titulo do Filme:");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Digite o Ano do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição do Filme:");
            string entradaDescricao = Console.ReadLine();

            System.Console.WriteLine("Digite o endereço do Trailer do Filme:");
            string entradaTrailer = Console.ReadLine();

            Filmes atualizaFilmes = new Filmes(id: indiceFilme, 
                                                genero: (Generos)entradaGenero,
                                                titulo: entradaTitulo, 
                                                ano: entradaAno, 
                                                descricao: entradaDescricao,
                                                trailer: entradaTrailer);
            
            rep.Atualiza(indiceFilme, atualizaFilmes);
        }
        private static void ExcluirFilme()
        {
            System.Console.WriteLine("Digite o Id do Filme:");
            int indiceFilme = int.Parse(Console.ReadLine());
            rep.Excluir(indiceFilme);
        }

        private static void VisualizarFilme()
        {
            System.Console.WriteLine("Digite o Id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            var filme = rep.RetornaPorId(indiceFilme);
            System.Console.WriteLine(filme);
        }


        
        private static string EscolhaUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("JBO Lançamentos. Aproveite!");
            System.Console.WriteLine("O que deseja? ");

            System.Console.WriteLine("1 - Listar Filmes");
            System.Console.WriteLine("2 - Inseir novo Filme");
            System.Console.WriteLine("3 - Atualizar Filme");
            System.Console.WriteLine("4 - Excluir Filme");
            System.Console.WriteLine("5 - Visualizar Filme");
            System.Console.WriteLine("C - Limpar Tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string escolha = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return escolha;
        }
    }
}
