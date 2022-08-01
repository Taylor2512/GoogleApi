namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class GobalAdress_and_GoogleAdress
    {
        public GobalAdress_and_GoogleAdress()
        {
        }

        public GobalAdress_and_GoogleAdress(Guid id_GobalAdress, Guid id_GoogleAdress, GobalAdress gobalAdress, GoogleAdress googleAdress)
        {
            Id_GobalAdress = id_GobalAdress;
            Id_GoogleAdress = id_GoogleAdress;
            GobalAdress = gobalAdress;
            GoogleAdress = googleAdress;
        }


        public Guid Id_GobalAdress { get; set; }
        public Guid Id_GoogleAdress { get; set; }
        public GobalAdress GobalAdress { get; set; }
        public GoogleAdress GoogleAdress { get; set; }

    }
}