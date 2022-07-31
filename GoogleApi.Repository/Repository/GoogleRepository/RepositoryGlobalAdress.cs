using GoogleApi.DBContext.Context;
using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.Repository.Repository.GoogleRepository
{
    public class RepositoryGlobalAdress : IRepositoryGlobalAdress
    {
        private ApplicationDbContext _context;

        public RepositoryGlobalAdress(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<GobalAdress>> Get() => await _context.GobalAdress.ToListAsync();

        public async Task<GobalAdress> Get(Guid id) => await _context.GobalAdress.FindAsync(id);

        public Task<Task> GuardarBase()
        {
            throw new NotImplementedException();
        }

        public async Task<GobalAdress> Post(GobalAdress entidad)
        {
          return await  _context.Insertar(entidad);
           
        }

        public async Task<GobalAdress> Put(GobalAdress entidad)
        {
            return await _context.Insertar(entidad);
        }
    }
}
