
using System;

namespace dio.appseries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
             string opcaoUsuario = ObterOpcaoUsuario();
       
             while (opcaoUsuario.ToUpper() != "X")
            {
                swicth = (opcaoUsuario)
                {
                   case "1";
                   ListarSeries();
                   break;
                   case "2";
                   InserirSerie();
                   break;
                   case "3";
                   AtualizarSeries(); 
                   break;
                   case "4";
                   ExcluirSerie();
                   break;
                   case "5";
                   VisualizarSeries();
                   break;
                   case "6";
                   console.clear();
                   break;
                   case "7";
                   console.sair();

                default:
                throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpcaoUsuario();

            }
             console.WriteLine("Gratidão por utilizar nossos serviços.");
             console.ReadLine();
        }

        private static void AtualizarSeries();
        {
            console.write("Digite o id da série: ");
            it indideSerie = int.Parse(console.ReadLine());

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
           // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
           foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            console.writeline("{0}.{1}", i, Enum.GetName(typeof(Genero), i));
        }
        console.write("Digite o gênero entre as opções seguintes: ");
        it entradaGenero = int.Parse(console.ReadLine());

        console.write("Digite o Título da Série: ");
        string entradaTitulo = console.ReadLine();

        console.write("Digite o Ano de Início da Série: ");
          string entradaAno = int.Parse(console.ReadLine());

        console.write("Digite a Descição da Série: ");
        string entradaDescricao = console.ReadLine();

        Serie atualizarSerie = new Serie(id: indiceSerie), 
                                    genero: (Genero)entradaGenero, 
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);

        repositorio.Atualiza(indiceSerie, atualizarSerie);
        }

        private static void ListarSeries();
        {
            console.writeLine("Listar séries.");
            var lista = new repositorio.lista();

            if (lista.count ==0)
            {
                console.writeLine("Nenhuma série cadastrada.")
                return; 
            }
               
           foreach (var series in lista)
           { 
               console.writeLine("ID {0}: {1}", series.retornaId(), serie.retornaTitulo());
           }
              
        }
        
        private static void InserirSerie()
        {
            console.writeLine("Inserir nova série");

            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
           // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
           foreach (int i in Enum.GetValues(typeof(Genero)))
        {
            console.writeline("{0}.{1}", i, Enum.GetName(typeof(Genero), i));
        }
        console.write("Digite o gênero entre as opções seguintes: ");
        it entradaGenero = int.Parse(console.ReadLine());

        console.write("Digite o Título da Série: ");
        string entradaTitulo = console.ReadLine();

        console.write("Digite o Ano de Início da Série: ");
          string entradaAno = int.Parse(console.ReadLine());

        console.write("Digite a Descição da Série: ");
        string entradaDescricao = console.ReadLine();

        Serie novaSerie = new Serie(id: repositorio.ProximoId(), 
                                    genero: (Genero)entradaGenero, 
                                    titulo: entradaTitulo,
                                    ano: entradaAno,
                                    descricao: entradaDescricao);

        repositorio.Insere(novaSerie);
        }

        private static string ObterOpcaoUsuario ()
        {
            console.WriteLine();
            console.WriteLine("GiraRosa Séries a seu dispor!");
            console.WriteLine("Informe a opção desejada:");

            console.WriteLine("1. Listar séries");
            console.WriteLine("2. Inserir Nova série");
            console.WriteLine("3. Atualizar série");
            console.WriteLine("4. Excluir série");
            console.WriteLine("5. Visualizar Série");
            console.WriteLine("C. Limpar Tela");
            console.WriteLine("X. Sair");
            console.WriteLine();

            string opcaoUsuario = console.ReadLine().ToUpper();
            console.WriteLine();
            return opcaoUsuario;
        }
    }
}  
