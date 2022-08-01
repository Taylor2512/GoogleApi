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
    public class Repositoriolocation_type : IRepositoriolocation_type
    {
        private readonly ApplicationDbContext _context;

        public Task<List<location_type>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<location_type> Get(int id)
        {
            return await _context.location_type.FindAsync(id);
        }

        public async Task<location_type> Get(string id)
        {
            return await _context.location_type.FindAsync(id);
        }

        public Task<Task> GuardarBase()
        {
            throw new NotImplementedException();
        }

        public async Task<location_type> Post(location_type entidad)
        {
            var encontrado = await Get(entidad.Name);
            if (encontrado== null)
            {
                _context.Add(entidad);
                await _context.SaveChangesAsync();
                return entidad;
            }
            return entidad = encontrado;
        }

        public Task<location_type> Put(location_type entidad)
        {
            throw new NotImplementedException();
        }
    }
}
