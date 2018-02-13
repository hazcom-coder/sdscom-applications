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
        private readonly IConfiguration config;
        private IMemoryCache cache;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_config"></param>
        /// <param name="_cache"></param>
        public UserService(IConfiguration _config, IMemoryCache _cache) : base(_config, _cache)
        {
            config = _config;
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

            using (var db = new SDSComContext(config))
            {
                user = db.Users.Find(userid);
            }

            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User GetByName(string username)
        {
            User user = new User();
            using (var db = new SDSComContext(config))
            {
                user = db.Users.Single(x => x.UserName == username);
            }
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<User> GetAll()
        {
            List<User> userList = new List<User>();
            using (var db = new SDSComContext(config))
            {
                userList = db.Users.ToList();
            }
            return userList;
        }

        public bool Delete(User user)
        {
            bool ok = false;
            try
            {
                using (var db = new SDSComContext(config))
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                    ok = true;
                }
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
                using (var db = new SDSComContext(config))
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
