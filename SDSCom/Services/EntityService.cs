using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SDSCom.Models;
using Npgsql.PostgresTypes;
using Npgsql;
using System.Data;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class EntityService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;
        
        /// <summary>
        /// 
        /// </summary>
        public EntityService(SDSComContext _db, IMemoryCache _cache) 
            :base(_db, _cache)
        {
            db = _db;
            cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Entity Save(Entity entity)
        {           
            if (entity.Id == 0)
            {
                db.Add<Entity>(entity);
                db.SaveChanges();
            }
            else
            {
                db.Update(entity);
                db.SaveChanges();
            }

            return entity;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityid"></param>
        /// <returns></returns>
        public Entity Get(long entityid)
        {
            Entity entity = new Entity();

            if (entityid == 0)
            {
                return entity;
            }
            return db.Entities.Single<Entity>(e => e.Id == entityid);
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entitytype"></param>
        /// <returns></returns>
        public List<Entity> GetByType(EntityTypeEnum entitytype)
        {            
            return db.Entities.Where(c => c.EntityType == (int)entitytype).ToList();         
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EntityType> GetEntityTypes()
        {            
            return db.EntityTypes.ToList();
        }
    }
}
