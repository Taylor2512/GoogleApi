using System.ComponentModel.DataAnnotations;

namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class location_type
    {
        public location_type()
        {
        }

        [Key]
        public int Id_location_type { get; set; }
        public string Name { get; set; }
        public List<geometry> geometry { get; set; }

        public location_type(int id_location_type, string name, List<geometry> geometry)
        {
            Id_location_type = id_location_type;
            Name = name;
            this.geometry = geometry;
        }
    }
}