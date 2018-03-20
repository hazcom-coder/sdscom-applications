using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;
using SDSCom.Models;
using Newtonsoft.Json;

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
            }
            else
            {
                db.Update(entity);
            }
            db.SaveChanges();

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
            return db.EntitiesReader.Single(e => e.Id == entityid);
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entitytype"></param>
        /// <returns></returns>
        public List<Entity> GetByType(EntityTypeEnum entitytype)
        {            
            return db.EntitiesReader.Where(c => c.EntityType == (int)entitytype).ToList();         
        }       

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EntityType> GetEntityTypes()
        {    
            return db.EntityTypes.ToList();
        }

        #region DataSheet operations
        public string InitDataSheet()
        {
            Datasheet dSheet = new Datasheet()
            {
                AccidentalReleaseMeasures = new AccidentalReleaseMeasures(),
                Composition = new Composition(),
                DisposalConsiderations = new DisposalConsiderations(),
                EcologicalInformation = new EcologicalInformation(),
                ExposureControlPersonalProtection = new ExposureControlPersonalProtection(),
                FireFightingMeasures = new FireFightingMeasures(),
                FirstAidMeasures = new FirstAidMeasures(),
                HandlingAndStorage = new HandlingAndStorage(),
                HazardIdentification = new HazardIdentification(),
                IdentificationSubstPrep = new IdentificationSubstPrep(),
                InformationFromExportingSystem = new InformationFromExportingSystem(),
                OtherInformation = new OtherInformation(),
                PhysicalChemicalProperties = new PhysicalChemicalProperties(),
                RegulatoryInfo = new RegulatoryInfo(),
                StabilityReactivity = new StabilityReactivity(),
                ToxicologicalInformation = new ToxicologicalInformation(),
                TransportInformation = new TransportInformation()
            };
            
            return base.Serialize<Datasheet>(dSheet);
        }

        #endregion

    }
}
