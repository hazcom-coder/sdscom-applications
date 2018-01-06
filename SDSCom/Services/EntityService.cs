using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SDSCom.Models;
using Npgsql.PostgresTypes;
using Npgsql;
using ServiceStack.OrmLite;
using ServiceStack;
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
            using (IDbConnection db = DbFactory.Open())
            {
                if (entity.ID == 0)
                {
                    entity.ID = db.Insert(entity, true);
                }
                else
                {
                    db.Update(entity);
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
            using (IDbConnection db = DbFactory.Open())
            {
                entity = db.SingleById<Entity>(entityid);
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
            using (IDbConnection db = DbFactory.Open())
            {
                entities = db.Select<Entity>(x => x.EntityType ==  Convert.ToInt32(entitytype));
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
            using (IDbConnection db = DbFactory.Open())
            {
                entityTypes = db.Select<EntityType>();
            }
            return entityTypes;
        }
    }
}
