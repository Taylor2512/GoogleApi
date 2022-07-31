namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class address_components:Entity<Guid>
    {
        public string long_name { get; set; }
        public string short_name { get; set; }
        public List<address_components_and_GoogleAdressType> types { set; get; }

    }
}