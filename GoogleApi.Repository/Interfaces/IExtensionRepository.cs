using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository.Interfaces
{
    public interface IExtensionRepository
    {
        public IRepositoryGlobalAdress repositoryGlobalAdress { get; set; }
        public IMapper mapper { get; set; }
        public IRepositoriobounds repositoriobounds { get; set; }
        public IRepositorioCordenadas repositorioCordenadas { get; set; }

    }

}
