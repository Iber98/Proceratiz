using Proceratiz;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proceratiz
{
    //Em Construção

    public class GString : Geracao
    {
        public override event EventHandler<string>? ItemGerado;

        //Gera Proceduralmente Letras do index Minimo ao Máximo de uma Coleção Genérica
        //A Quantidade de Letras Gerados Depende do Tamanho da Coleção
        public IEnumerable<string> GeracaoProcedural(IEnumerable<string> items)
        {
            var random = new Random();
            var list = items.ToArray();

            foreach (var i in list)
            {
                ItemGerado?.Invoke(this, "Item Gerado");

                yield return list[random.Next(0, list.Length)];
            }
        }
    }
}
