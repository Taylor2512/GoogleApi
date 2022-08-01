using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Domain.Entities.Geoglobal
{
    public class Cordenadas:Entity<Guid>
    {
        public Cordenadas()
        {
        }

        public Cordenadas(Guid id) : base(id)
        {
        }

        public Cordenadas(double latitud, double longitud)
        {
            this.latitud = latitud;
            Longitud = longitud;
        }

        public double latitud { set; get; }
        public double Longitud { set; get; }
       /* public Cordenadas_southwest Cordenadas_southwest { set; get; }
        public Cordenadas_northeast Cordenadas_northeast { set; get; }
        public Cordenadas_location Cordenadas_location { set; get; }*/
       public bounds northeast { set; get; }
       public bounds southwest { set; get; }
       public geometry geometry { set; get; }
    }
}
