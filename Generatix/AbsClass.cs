namespace Generatix
{
    public abstract class Geracao
    {
        public int Seed { get; set; }
        public int Quantity { get; set; }

        // "Limit" só Deve ser Usado em Geração de Números (Por Enquanto)
        public int Limit { get; set; }

        public virtual void GeracaoProcedural(int[] items, int number){}
    }
}