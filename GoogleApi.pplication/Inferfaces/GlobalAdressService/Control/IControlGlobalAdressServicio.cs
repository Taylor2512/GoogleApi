using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Inferfaces.GlobalAdressService.Control
{
    public interface IControlGlobalAdressServicio<entidad,entidad2,id,str>
    {
        public  Task<entidad> Post(entidad2 entidad);
    }
}
