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
}
