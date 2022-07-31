namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class Cordenadas_southwest:Entity<Guid>
    {
        public Cordenadas_southwest()
        {
        }

        public Cordenadas_southwest(Guid id) : base(id)
        {
        }

        public bounds bounds { get; set; }
        public Guid Id_Cordenadas { get; set; }
        public Cordenadas Cordenadas { get; set; }
    }
}