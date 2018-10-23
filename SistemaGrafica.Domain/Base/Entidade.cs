namespace SistemaGrafica.Domain.Base
{
    public abstract class Entidade
    {
        public virtual int Id { get; set; }

        public abstract void Validar();
    }
}
