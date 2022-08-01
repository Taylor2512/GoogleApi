namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class geometry:Entity<Guid>
    {
        public geometry()
        {
        }

        public geometry(Guid id) : base(id)
        {
        }

        public geometry(Guid id_bounds, Guid id_viewport, bounds bounds, Guid id_location, Cordenadas location, int id_location_type, location_type location_Types, bounds viewport, GoogleAdress googleAdress) : this(id_bounds)
        {
            Id_viewport = id_viewport;
            this.bounds = bounds;
            Id_location = id_location;
            this.location = location;
            Id_location_type = id_location_type;
            this.location_Types = location_Types;
            this.viewport = viewport;
            GoogleAdress = googleAdress;
        }

        public Guid Id_bounds { get; set; }
        public Guid Id_viewport { get; set; }
        public bounds bounds { get; set; }
        public Guid Id_location { get; set; }
        public Cordenadas location { get; set; }
        public int Id_location_type { get; set; }
        public location_type location_Types { get; set; }
        public bounds viewport { get; set; }
        public GoogleAdress GoogleAdress { get; set; }

    }
}