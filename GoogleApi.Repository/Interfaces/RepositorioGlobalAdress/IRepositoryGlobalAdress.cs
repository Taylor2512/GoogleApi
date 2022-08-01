using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.Repository.Interfaces.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository.Interfaces
{
    public interface IRepositoryGlobalAdress: IControlRepositoryGlobalAdress<GobalAdress,Guid,string>
    {
    }
    public interface IRepositoriobounds : IControlRepositoriobounds<bounds, Guid, string>
    {

    }
    public interface IRepositoriolocation_type : IControlRepositoriolocation_type<location_type, int, string>
    {

    }
    public interface IRepositorioCordenadas : IControlRepositorioCordenadas<Cordenadas,Guid,string>
    {
    }
}
