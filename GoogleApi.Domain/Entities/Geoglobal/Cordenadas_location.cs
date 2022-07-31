namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class Cordenadas_location:Entity<Guid>
    {
        public Cordenadas_location()
        {
        }

        public Cordenadas_location(Guid id) : base(id)
        {
        }

        public Guid Id_Cordenadas { get; set; }
      //  public Cordenadas Cordenadas { get; set; }

    }
}