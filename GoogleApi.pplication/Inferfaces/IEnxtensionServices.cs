using AutoMapper;
using GoogleApi.pplication.Inferfaces.GlobalAdressService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.Inferfaces
{
    public interface IEnxtensionServices
    {
        public IMapper mapper { set; get; }
        public IGlobalAdressServicio globalAdressServicio { set; get; }

    }
}
