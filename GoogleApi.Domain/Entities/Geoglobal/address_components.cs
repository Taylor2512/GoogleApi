namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class address_components:Entity<Guid>
    {
        public address_components()
        {
        }

        public address_components(Guid id) : base(id)
        {
        }

        public string long_name { get; set; }
        public string short_name { get; set; }


        public List<GoogleAdress_and_address_components> GoogleAdress_and_address_components { set; get; }

        public List<address_components_and_GoogleAdressType> types { set; get; }

    }
}