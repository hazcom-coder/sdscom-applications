using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SDSCom.Models;
using Serilog;

namespace SDSCom.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : BaseService
    {
        private readonly SDSComContext db;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public UserService(SDSComContext _db, IMemoryCache _cache) : base(_db, _cache)
        {
            db = _db;
            cache = _cache;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public User GetByID(int userid)
        {
            User user = new User();
            if (userid == 0 )
            {
                return user;
            }

            user = db.UsersReader.Single(e => e.Id == userid);

            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User GetByName(string username)
        {
            return db.UsersReader.Single(x => x.UserName == username);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetAll()
        {
           return db.UsersReader.ToList();
        }

        public bool Delete(User user)
        {
            bool ok = false;
            try
            {              
                db.Users.Remove(user);
                db.SaveChanges();
                ok = true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "UserService>Delete");
            }

            return ok;
        }

        public User Save(User user)
        {
            bool ok = false;
            try
            {                
                if (user.Id == 0)
                {
                    db.Users.Add(user);
                }
                else
                {
                    db.Users.Update(user);
                }
                ok = (db.SaveChanges() == 1); 
            }
            catch (Exception ex)
            {
                Log.Error(ex, "UserService>AddNew");
            }

            return user;
        }

        public bool Validate(string userName, string password )
        {
            bool ok = false;
           
            User user = GetByName(userName);

            if (user == null)
            {
                return ok;
            }

            if (user.Password == password)
            {
                ok = true;
            }

            return ok;
        }
    }
}
