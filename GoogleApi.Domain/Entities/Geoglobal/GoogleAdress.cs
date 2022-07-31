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
        public List<GoogleAdress_and_address_components> GoogleAdress_and_address_components { get; set; }
        public Guid Id_geometry { get; set; }
        public geometry geometry { get; set; }
        public string formatted_address { get; set; }
        public string place_id { get; set; }
        public Guid Id_plus_code { get; set; }
        public Guid Id_GobalAdress { get; set; }
        public plus_code plus_code { get; set; }
        public GobalAdress GobalAdress { get; set; }
        public List<GoogleAdress_tiene_types> types { get; set; }
    }
}