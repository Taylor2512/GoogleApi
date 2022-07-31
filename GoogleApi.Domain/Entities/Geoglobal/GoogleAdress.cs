namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class GoogleAdress:Entity<Guid>
    {
        public GoogleAdress()
        {
        }

        public GoogleAdress(Guid id) : base(id)
        {
        }
        public List<address_components> taddress_componentsypes { get; set; }
        public Guid Id_geometry { get; set; }
        public geometry geometry { get; set; }
        public string formatted_address { get; set; }
        public string place_id { get; set; }
        public Guid Id_plus_code { get; set; }
        public plus_code plus_code { get; set; }
        public List<GoogleAdress_tiene_types> types { get; set; }


    }
}