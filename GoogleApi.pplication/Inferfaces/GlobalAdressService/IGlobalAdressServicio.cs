using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.pplication.Dtos.GoogleGlobal;
using GoogleApi.pplication.Inferfaces.GlobalAdressService.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Inferfaces.GlobalAdressService
{
    public interface IGlobalAdressServicio: IControlGlobalAdressServicio<GobalAdress, CordenadasDto,Guid,string>
    {
    }
}
