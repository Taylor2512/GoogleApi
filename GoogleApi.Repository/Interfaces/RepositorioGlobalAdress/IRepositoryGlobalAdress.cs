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
}
