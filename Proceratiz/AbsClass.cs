namespace Proceratiz
{
    public abstract class Geracao
    {
        abstract public event EventHandler<string>? ItemGerado;

        public int Seed { get; set; }
    }
}