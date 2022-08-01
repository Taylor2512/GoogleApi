using AutoMapper;
using GoogleApi.pplication.Inferfaces;
using GoogleApi.pplication.Inferfaces.GlobalAdressService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.pplication.AppServices
{
    public class ExtensionServices : IEnxtensionServices
    {
        public IMapper mapper { get; set; }
        public IGlobalAdressServicio globalAdressServicio { get ; set ; }

        public ExtensionServices(IMapper mapper, IGlobalAdressServicio globalAdressServicio)
        {
            this.mapper = mapper;
            this.globalAdressServicio = globalAdressServicio;
        }
    }
}
