using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Linq;
using SDSCom.Models;
using System;

namespace SDSCom.Services
{
    public class DocumentService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        public DocumentService(SDSComContext _db, IMemoryCache _cache)
            : base(_db, _cache)
        {
            db = _db;
            cache = _cache;
        }

        public Document Get(long id)
        {
            return db.DocumentsReader.Where(d=>d.Id == id).FirstOrDefault();
        }

        public List<Document> GetBySource(string source)
        {
            return db.DocumentsReader.Where(d => d.Source == source && d.Active == true).ToList();
        }

        public List<Document> GetAll()
        {
            return db.DocumentsReader.ToList();
        }

        public List<Document> GetByDate(DateTime date)
        {
            return db.DocumentsReader.Where(d => d.CreatedDate.Date == date.Date && d.Active == true).ToList();
        }

        public List<Document> GetByUser(int userId)
        {
            return db.DocumentsReader.Where(d => d.CreatedUser == userId && d.Active == true).ToList();
        }

        public Document Save(Document document)
        {
            if (document.Id == 0)
            {
                db.Add<Document>(document);
            }
            else
            {
                db.Update<Document>(document);
            }               
            
            db.SaveChanges();

            return document;
        }

        public bool ToggleActive(Document document)
        {
            document.Active = !document.Active;
            db.Update<Document>(document);
            db.SaveChanges();
            return true;
        }
    }
}
