using Proceratiz;

namespace Proceratiz
{
    class GNumber : Geracao
    {
        public override void GeracaoProcedural(int[] items, int number)
        {
            var random = new Random(Seed);
            int apparition = 0;

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = random.Next(1, Quantity);
                if (items[i] == number) apparition++;
            }

            foreach (int m in items) { Console.WriteLine($"[{m}]"); }
            Console.WriteLine($"\n O Seu Número Apareceu {apparition} Vezes");
        }
    }
}