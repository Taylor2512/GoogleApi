namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class address_components_and_GoogleAdressType
    {
        public Guid Id_address_components { get; set; }
        public address_components address_components { get; set; }
        public int Id_GoogleAdress_types { get; set; }
        public GoogleAdress_types GoogleAdress_types { get; set; }
    }
}