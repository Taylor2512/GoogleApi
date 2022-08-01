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
    public class RepositorioCordenadas : IRepositorioCordenadas
    {
        private  ApplicationDbContext _context;

        public RepositorioCordenadas(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Cordenadas>> Get()
        {
            return await _context.cordenadas.ToListAsync();
        }

        public async Task<Cordenadas> Get(Guid id)
        {
            return await _context.cordenadas.Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Task> GuardarBase()
        {
          await  _context.SaveChangesAsync();
            return Task.CompletedTask;
        }

        public async Task<Cordenadas> Post(Cordenadas entidad)
        {
            var encontrado= await _context.cordenadas.Where(e=>e.latitud.Equals(entidad.latitud)&&e.Longitud.Equals(entidad.Longitud)).SingleOrDefaultAsync();
            if (encontrado == null)
            {

                await _context.Insertar(entidad);
                return entidad;
            }


            
            return entidad=encontrado;
        }

        public async Task<Cordenadas> Put(Cordenadas entidad)
        {
            return await _context.Actualizar(entidad);
        }
    }
}
