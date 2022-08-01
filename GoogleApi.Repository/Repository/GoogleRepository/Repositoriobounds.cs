using GoogleApi.DBContext.Context;
using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository.Repository.GoogleRepository
{
    public class Repositoriobounds : IRepositoriobounds
    {
        private readonly ApplicationDbContext _context;

        public Repositoriobounds(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<bounds>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bounds> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Task> GuardarBase()
        {
            throw new NotImplementedException();
        }

        public async Task<bounds> Post(bounds entidad)
        {
            return await _context.Insertar(entidad);
        }

        public Task<bounds> Put(bounds entidad)
        {
            throw new NotImplementedException();
        }
    }
}
