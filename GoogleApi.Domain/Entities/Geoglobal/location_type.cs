using System.ComponentModel.DataAnnotations;

namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class location_type
    {
        [Key]
        public int Id_location_type { get; set; }
        public string Name { get; set; }
        public List<geometry> geometry { get; set; }
    }
}