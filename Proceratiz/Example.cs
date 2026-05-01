using Proceratiz;

namespace Proceratiz
{
    class Example
    {
        async static void Main()
        static void Main()
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
