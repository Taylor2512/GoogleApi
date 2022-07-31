using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class GobalAdress:Entity<Guid>
    {
        public Guid Id_plus_code { get; set; }
        public plus_code plus_Code { get; set; }
        public List<GoogleAdress> GoogleAdress { get; set; }
    }
}
