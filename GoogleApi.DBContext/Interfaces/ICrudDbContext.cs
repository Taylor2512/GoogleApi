using GoogleApi.DBContext.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.DBContext.Interfaces
{
    public interface ICrudDbContext<entidad,id,str>
    {
        //  abstract ApplicationDbContext _context { get; set; }
        public Task<Task> GuardarBase();
        public  Task<List<entidad>> Get();
        public  Task<entidad> Get(id id);
        public  Task<entidad> Post(entidad entidad);
        public  Task<entidad> Put(entidad entidad);
        
    }
}
