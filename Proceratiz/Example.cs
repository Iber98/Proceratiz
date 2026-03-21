using Proceratiz;

namespace Proceratiz
{
    class Example
    {
        // "Limit" só Deve ser Usado em Geração de Números

        static void Main()
        {
            var letters = new GString();

            Console.Write(" Digite a Seed: ");
            letters.Seed = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite Quantas Letras serão Geradas: ");
            letters.Quantity = Convert.ToInt32(Console.ReadLine());


            Console.Write(" Digite a Letra que Deseja Verificar: ");
            string? letter = (Console.ReadLine());

            //var matriz = new int[letter.Limit];

            letters.GeracaoProcedural(letter);
        }
    }
}