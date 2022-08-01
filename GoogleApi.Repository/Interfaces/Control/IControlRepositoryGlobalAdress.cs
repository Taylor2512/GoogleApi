using GoogleApi.DBContext.Interfaces;
using GoogleApi.Domain.Entities.Geoglobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository.Interfaces.Control
{
    public interface IControlRepositoryGlobalAdress<entidad,id,str>:ICrudDbContext<GobalAdress,Guid,string>
    {
    }
    public interface IControlRepositoriobounds<entidad, id, str> : ICrudDbContext<entidad, id, str>
    {

    }
    public interface IControlRepositoriolocation_type<entidad, id, str> : ICrudDbContext<entidad, id, str>
    {
        public Task<location_type> Get(str id);
    }
    public interface IControlRepositorioCordenadas<entidad,id,str>:ICrudDbContext<Cordenadas,Guid,string>
    {
    }
}
