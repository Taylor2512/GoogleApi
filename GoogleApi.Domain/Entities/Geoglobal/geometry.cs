namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class geometry:Entity<Guid>
    {
        public Guid Id_bounds { get; set; }
        public Guid Id_viewport { get; set; }
        public bounds bounds { get; set; }
        public Guid Id_location { get; set; }
        public Cordenadas location { get; set; }
        public int Id_location_type { get; set; }
        public location_type location_Type { get; set; }
        public bounds viewport { get; set; }
        public GoogleAdress GoogleAdress { get; set; }
    }
}