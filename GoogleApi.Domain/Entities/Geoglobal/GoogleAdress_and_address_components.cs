namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class GoogleAdress_and_address_components
    {
        public Guid Id_address_components { get; set; }
        public Guid Id_GoogleAdress { get; set; }
        public address_components address_Components { get; set; }
        public GoogleAdress GoogleAdress { get; set; }
    }
}