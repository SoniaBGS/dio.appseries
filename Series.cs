namespace dio.appseries
{
    public class Series : EntidadeBase
    {
        // Atributos

        private Genero Genero { get; set; } 
        private string Tìtulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

       //Métodos

       public Serie(int id, Genero genero, string título, string descricao, int ano)
       {
           this.id = id;
           this.Gênero = genero;
           this.Título = título;
           this.Descrição = descricao;
           this.Ano = ano;
       }

       public override string ToString()
       {
           // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
       }

       public string retornaTitulo()
       {
           return this.Titulo;
       }
       public int retonaId()
       {
           return this.Id;
       }
    }
}