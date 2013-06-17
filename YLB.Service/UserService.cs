using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YLB.IService;
using YLB.IDao;

namespace YLB.Service
{
    /// <summary>
    /// 创建人：℡乄℡瞬间：http://www.github.com/yksoft/springdemo
    /// </summary>
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
