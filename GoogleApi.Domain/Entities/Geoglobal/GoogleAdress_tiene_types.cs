namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class GoogleAdress_tiene_types
    {
        public Guid Id_GoogleAdress { get; set; }
        public GoogleAdress GoogleAdress { get; set; }
        public int Id_GoogleAdress_types { get; set; }
        public GoogleAdress_types GoogleAdress_types { get; set; }

        public GoogleAdress_tiene_types(Guid id_GoogleAdress, GoogleAdress googleAdress, int id_GoogleAdress_types, GoogleAdress_types googleAdress_types)
        {
            Id_GoogleAdress = id_GoogleAdress;
            GoogleAdress = googleAdress;
            Id_GoogleAdress_types = id_GoogleAdress_types;
            GoogleAdress_types = googleAdress_types;
        }

        public GoogleAdress_tiene_types()
        {
        }
    }
}