namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class plus_code:Entity<Guid>
    {
        public plus_code()
        {
        }

        public plus_code(Guid id) : base(id)
        {
        }

        public string compound_code { get; set; }
        public string global_code { get; set; }
        public GoogleAdress GoogleAdress { get; set; }
    
    }
}