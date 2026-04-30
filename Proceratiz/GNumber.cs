using Proceratiz;

namespace Proceratiz
{
    class GNumber : Geracao
    {
        public override event EventHandler<string>? ItemGerado;

        //Gera Proceduralmente Números do valor Minimo ao Máximo de uma Coleção Genérica
        //A Quantidade de Números Gerados Depende do Tamanho da Coleção
        public IEnumerable<int> GeracaoProcedural(IEnumerable<int> items)
        {
            var random = new Random(Seed);

            foreach (var i in items)
            {
                //Notifica a Geração do Número Caso Assinado
                ItemGerado?.Invoke(this, "Item Gerado");
                
                yield return random.Next(items.Min(), items.Max());
            }
        }
    }
}