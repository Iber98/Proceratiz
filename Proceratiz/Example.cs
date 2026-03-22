using Proceratiz;

namespace Proceratiz
{
    class Example
    {
        static void Main()
        {
            try
            {
                var letters = new GString();

                Console.Write(" Digite a Seed: ");
                letters.Seed = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Digite Quantas Letras serão Geradas: ");
                letters.Quantity = Convert.ToInt32(Console.ReadLine());


                Console.Write(" Digite a Letra que Deseja Verificar: ");
                string? letter = (Console.ReadLine());

                letters.GeracaoProcedural(letter);
            }

            catch
            {
                Console.Write("Digite Valores Válidos!!!");
            }
        }
    }
}
