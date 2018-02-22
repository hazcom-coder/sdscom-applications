using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDSCom;
using SDSCom.Services;
using SDSCom.Models;
using System;

namespace SDSComTests
{
    [TestClass]
    public class UserTests
    {
        static DbContextOptions options;
        static SDSComContext db;
        static IMemoryCache cache;
        static UserService uSvc;

        [ClassInitialize]
        public static void AssmStart(TestContext context)
        {
            options = new DbContextOptionsBuilder<SDSComContext>()
                .UseInMemoryDatabase(databaseName: "SDSCom_User_Tests")
                .Options;

            db = new SDSComContext(options);
            cache = null;

            uSvc = new UserService(db, cache);
        }

        [ClassCleanup]
        public static void AssmStop()
        {

        }

        [TestMethod]
        public void Users_1000_Add_User()
        {  
            User newUser = new User {Active = true,
                                    CreateDate = DateTime.Now,
                                    Email = "test@test.com",
                                    FirstName = "first_test",
                                    LastName = "last_test",                                    
                                    IsAdmin = true,
                                    Password = "abc",
                                    UpdateDate = DateTime.Now,
                                    UserName = "tester3"};
            User user = uSvc.Save(newUser);

            Assert.IsTrue(user.Id != 0); 
        }

        [TestMethod]
        public void Users_1001_Get_UserList()
        {
            User newUser = new User
            {
                Active = true,
                CreateDate = DateTime.Now,
                Email = "test@test.com",
                FirstName = "first_test",
                LastName = "last_test",
                IsAdmin = true,
                Password = "abc",
                UpdateDate = DateTime.Now,
                UserName = "tester1"
            };
            uSvc.Save(newUser);

            newUser = new User
            {
                Active = true,
                CreateDate = DateTime.Now,
                Email = "test@test.com",
                FirstName = "first_test",
                LastName = "last_test",
                IsAdmin = true,
                Password = "abc",
                UpdateDate = DateTime.Now,
                UserName = "tester2"
            };
            uSvc.Save(newUser);

            var userList = uSvc.GetAll();
                
            Assert.IsTrue(userList.Count > 0 );
        }

        [TestMethod]
        public void Users_1002_Get_User_ID()
        {
            User user =  uSvc.GetByID(1);

            Assert.IsTrue(user != null);
        }

        [TestMethod]
        public void Users_1003_Get_User()
        {
            User user = uSvc.GetByName("tester1");

            Assert.IsTrue(user != null);
        }


        [TestMethod]
        public void Users_1004_Update_User()
        {
            User newUser = new User
            {
                Active = true,
                CreateDate = DateTime.Now,
                Email = "test@test.com",
                FirstName = "first_test",
                LastName = "last_test",
                IsAdmin = true,
                Password = "abc",
                UpdateDate = DateTime.Now,
                UserName = "tester4"
            };
            uSvc.Save(newUser);

            User user = uSvc.GetByName("tester4");

            user.Email = "updated@test.com";
            uSvc.Save(user);

            user = uSvc.GetByName("tester4");

            Assert.IsTrue(user.Email == "updated@test.com");
        }

    }
}
