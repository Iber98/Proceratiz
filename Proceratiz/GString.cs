using Proceratiz;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proceratiz
{
    //Em Construção
    public class GString : Geracao
    {
        public void GeracaoProcedural(string? letter)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyz";
            int apparition = 0;
            var random = new Random(Seed);

            if ((letter != null) && (letter != ""))
            {
                letter.ToLower();

                for (int l = 0; l < Quantity; l++)
                {
                    string generator = Convert.ToString(letters[random.Next(0, 25)]);

                    if (letter == generator) apparition++;

                    Console.WriteLine($"[{generator}]");
                }

                Console.WriteLine($"Sua Letra Apareceu {apparition} Vezes");
            }

            else Console.Write("Inválido");
        }
    }
}
