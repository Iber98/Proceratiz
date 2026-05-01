using Proceratiz;

namespace Proceratiz
{
    class Example
    {
<<<<<<< HEAD
        // "Limit" só Deve ser Usado em Geração de Números

        async static void Main()
=======
        static void Main()
>>>>>>> c032955e22d3b6a5d1a7d1236ce394be0419c3e8
        {
            try
            {
                var gerador = new GString();

                //Expressão Lambda Assinante
                gerador.ItemGerado += (obj, msg) => Console.WriteLine(msg);

                //Coleção
                var list = new List<string> { "adkvc", "sdvh", "dwkgbv", "dalikkib", "odiwgb" };

                //Entrada para a Seed da Geração
                gerador.Seed = Convert.ToInt32(Console.ReadLine());

                //Saída e Notificação do Evento
                foreach (var g in gerador.GeracaoProcedural(list)) 
                {
                    await TimeDelay(1000);
                    Console.WriteLine(g);
                }
            }

            catch(FormatException)
            {
                Console.Write(" Digite uma Seed Númerica!!!");
            }
        }

        private static async Task TimeDelay(int time) => await Task.Delay(time);
    }
}
