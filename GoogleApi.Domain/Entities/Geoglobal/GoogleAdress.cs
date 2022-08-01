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

        public GoogleAdress(List<GoogleAdress_and_address_components> googleAdress_and_address_components, Guid id_geometry, geometry geometry, string formatted_address, string place_id, Guid id_plus_code, Guid id_GobalAdress, plus_code plus_code, List<GobalAdress_and_GoogleAdress> gobalAdress_and_GoogleAdress, List<GoogleAdress_tiene_types> types)
        {
            GoogleAdress_and_address_components = googleAdress_and_address_components;
            Id_geometry = id_geometry;
            this.geometry = geometry;
            this.formatted_address = formatted_address;
            this.place_id = place_id;
            Id_plus_code = id_plus_code;
            Id_GobalAdress = id_GobalAdress;
            this.plus_code = plus_code;
            GobalAdress_and_GoogleAdress = gobalAdress_and_GoogleAdress;
            this.types = types;
        }

        public List<GoogleAdress_and_address_components> GoogleAdress_and_address_components { get; set; }
        public Guid Id_geometry { get; set; }
        public geometry geometry { get; set; }
        public string formatted_address { get; set; }
        public string place_id { get; set; }
        public Guid Id_plus_code { get; set; }
        public Guid Id_GobalAdress { get; set; }
        public plus_code plus_code { get; set; }
        public List<GobalAdress_and_GoogleAdress> GobalAdress_and_GoogleAdress { get; set; }
        public List<GoogleAdress_tiene_types> types { get; set; }
    }
}