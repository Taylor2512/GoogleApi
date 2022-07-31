using System.ComponentModel.DataAnnotations;

namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class GoogleAdress_types
    {
        [Key]
        public int Id_GoogleAdress_types { get; set; }
        public string Name { get; set; }
        public List<GoogleAdress_tiene_types> GoogleAdress_tiene_types { get; set; }
        public List<address_components_and_GoogleAdressType> address_components_and_GoogleAdressType { get; set; }


    }
}