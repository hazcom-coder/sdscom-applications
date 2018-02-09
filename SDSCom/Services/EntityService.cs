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
        private readonly IConfiguration config;
        private IMemoryCache cache;
        
        /// <summary>
        /// 
        /// </summary>
        public EntityService(IConfiguration _config, IMemoryCache _cache) 
            :base(_config, _cache)
        {
            config = _config;
            cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Entity Save(Entity entity)
        {
            using (var db = new SDSComContext(config))
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

            using (var db = new SDSComContext(config))
            {
                entity = db.Entities.Single<Entity>(e => e.Id == entityid);
            }
            return entity;
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entitytype"></param>
        /// <returns></returns>
        public List<Entity> GetByType(EntityTypeEnum entitytype)
        {
            List<Entity> entities = new List<Entity>();
            using (var db = new SDSComContext(config))
            {               
                entities = db.Entities.Where(c => c.EntityType == (int)entitytype).ToList();
            }
            return entities;           
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EntityType> GetEntityTypes()
        {
            List<EntityType> entityTypes = new List<EntityType>();
            using (var db = new SDSComContext(config))
            {
                entityTypes = db.EntityTypes.ToList();
            }
            return entityTypes;
        }
    }
}
