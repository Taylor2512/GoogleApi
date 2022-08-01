using AutoMapper;
using GoogleApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository
{
    public class ExtensionRepository : IExtensionRepository
    {
        public IRepositoryGlobalAdress repositoryGlobalAdress { get ; set; }
        public IMapper mapper { get; set; }
        public IRepositoriobounds repositoriobounds{ get; set; }
        public IRepositorioCordenadas  repositorioCordenadas { get; set; }

        public ExtensionRepository(IRepositoryGlobalAdress repositoryGlobalAdress, IMapper mapper, IRepositoriobounds repositoriobounds, IRepositorioCordenadas repositorioCordenadas)
        {
            this.repositoryGlobalAdress = repositoryGlobalAdress;
            this.mapper = mapper;
            this.repositoriobounds = repositoriobounds;
            this.repositorioCordenadas = repositorioCordenadas;
        }
    }
}
