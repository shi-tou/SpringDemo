using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YLB.IService;
using YLB.IDao;

namespace YLB.Service
{
    public class UserService : IUserService
    {
        private IUserDao userDao
        {
            set;
            get;
        }
        public bool Login(string userName, string passWord)
        {
            return userDao.Login(userName, passWord);
        }
    }
}
