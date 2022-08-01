using GoogleApi.Domain.Entities.Geoglobal;
using GoogleApi.Domain.Parameters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApi.DBContext.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<address_components> address_Components { get; set; }
        public DbSet<GoogleAdress> googleAdresses { get; set; }
        public DbSet<GoogleAdress_and_address_components> GoogleAdress_and_address_components { get; set; }
        public DbSet<address_components_and_GoogleAdressType> address_components_and_GoogleAdressType { get; set; }
        public DbSet<bounds> bounds { get; set; }
        public DbSet<geometry> geometry { get; set; }
        public DbSet<GobalAdress> GobalAdress { get; set; }
        public DbSet<GoogleAdress_tiene_types> GoogleAdress_tiene_types { get; set; }
        public DbSet<GoogleAdress_types> GoogleAdress_types { get; set; }
        public DbSet<location_type> location_type { get; set; }
        public DbSet<Cordenadas> cordenadas { get; set; }
        public  async Task<T> Insertar<T>(T t)
        {
            try
            {
                var result = t;
                Add(result);

                await SaveChangesAsync();
                t = result;
                return t;
            }
            catch (Exception ex)
            {
                Tools.messageError = ex.InnerException.Message ?? null;
                Tools.messageError = Tools.messageError ?? Tools.messageError + ex.Message;
                return default;
            }
        }   
        public  async Task<T> Eliminar<T>(T t)
        {
            try
            {
                Remove(t);
                await SaveChangesAsync();
                return t;
            }
            catch (Exception ex)
            {
                Tools.messageError = ex.Message ?? string.Empty;
                Tools.messageError = Tools.messageError ?? ex.InnerException.Message ?? string.Empty;
                return default;
            }
        }
        public  async Task<T?> Actualizar<T>(T t)
        {
            try
            {
                Update(t);
                await SaveChangesAsync();
                return t;
            }catch(Exception ex)
            {
                Tools.messageError = ex.InnerException.Message ?? null;
                Tools.messageError = Tools.messageError ?? Tools.messageError+ ex.Message;
                return default;
            }

        }  
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


        }
    }
}
