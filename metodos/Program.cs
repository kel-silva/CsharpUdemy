using System.Runtime.InteropServices;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância da classe MinhaClasse
            MinhaClasse minhaClasse = new MinhaClasse();

          


            // Chama o método Saudacao
            minhaClasse.Saudacao();
        }
    }

    // Define a classe MinhaClasse
    public class MinhaClasse
    {
        public void Saudacao()
        {
            Console.WriteLine("Bem vindo");
        }
    }
}