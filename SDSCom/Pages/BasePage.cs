using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SDSCom.Pages
{
    public static class SessionExtensions
    {
        public static bool? GetBoolean(this ISession session, string key)
        {
            var data = session.Get(key);
            if (data == null)
            {
                return null;
            }
            return BitConverter.ToBoolean(data, 0);
        }

        public static void SetBoolean(this ISession session, string key, bool value)
        {
            session.Set(key, BitConverter.GetBytes(value));
        }

        public static long? GetLong(this ISession session, string key)
        {
            var data = session.GetString(key);
            long result = 0;
            if (data == null)
            {
                return null;
            }
            else
            {
                result = long.Parse(data);
            }
            return result;
        }

        public static void SetLong(this ISession session, string key, long value)
        {
            session.SetString(key, value.ToString());
        }
    }


    public class BasePage : PageModel
    {
        public BasePage()
        {
            
        }

        /// <summary>
        /// Method to get all UserProfile settings
        /// </summary>
        public void GetUserProfileViewData()
        {
            ViewData["username"] = UserProfile_UserName;
            ViewData["userid"] = UserProfile_UserID;
            ViewData["componentid"] = UserProfile_ComponentID;
            ViewData["productid"] = UserProfile_ProductID;
            ViewData["uilanguage"] = UserProfile_UILanguage;
        }                

        public string UserProfile_UserName
        {           
            get => HttpContext.Session.GetString("username");
            set => HttpContext.Session.SetString("username", value);
        }

        public int UserProfile_UserID
        {
            get => HttpContext.Session.GetInt32("userid").GetValueOrDefault();
            set => HttpContext.Session.SetInt32("userid", value);
        }

        public long UserProfile_ProductID
        {
            get => HttpContext.Session.GetLong("productid").GetValueOrDefault();
            set => HttpContext.Session.SetLong("productid", value);
        }

        public long UserProfile_ComponentID
        {
            get => HttpContext.Session.GetLong("componentid").GetValueOrDefault();
            set => HttpContext.Session.SetLong("componentid", value);
        }

        public string UserProfile_UILanguage
        {
            get => HttpContext.Session.GetString("uilanguage");
            set => HttpContext.Session.SetString("uilanguage", value);
        }


        public string Translate(string basePhrase)
        {
            string trans = basePhrase;


            return trans;
        }



    }


}
