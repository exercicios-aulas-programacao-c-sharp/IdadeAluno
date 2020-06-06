using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dezoitoAnos = 18;
            DateTime dataNascimento = new DateTime(1986, 11, 05);
            DateTime dataDezoitoAnos = dataNascimento.AddYears(dezoitoAnos);

            string dataNascimentoLonga = dataNascimento.ToLongDateString();
            string dataDezoitoAnosLonga = dataDezoitoAnos.ToLongDateString();

            Console.WriteLine($"Eu nasci em {dataNascimentoLonga}");
            Console.WriteLine($"Aniversário de {dezoitoAnos} anos em {dataDezoitoAnosLonga}");
        }
    }
}
