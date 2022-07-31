namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class Cordenadas_northeast : Entity<Guid>
    {

        public Cordenadas_northeast(Guid id) : base(id)
        {
        }

        public Cordenadas_northeast(bounds bounds)
        {
            this.bounds = bounds;
        }

        public Cordenadas_northeast()
        {
        }

        public Guid Id_Cordenadas { get; set; }
        public Cordenadas Cordenadas { get; set; }
        public bounds bounds { get; set; }
    }
}