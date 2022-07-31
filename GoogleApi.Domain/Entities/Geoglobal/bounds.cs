using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class bounds:Entity<Guid>
    {
        public bounds(Guid id) : base(id)
        {
        }

  

        public Guid Id_northeast { get; set; }
        public Guid Id_southwest { get; set; }
  /*      public Cordenadas_northeast northeast { get; set; }
        public Cordenadas_southwest southwest { get; set; }*/
        public Cordenadas southwest { get; set; }
        public Cordenadas northeast { get; set; }
        public geometry geometry { get; set; }
        public geometry viewport { get; set; }
    }
}
