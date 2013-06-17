using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YLB.IDao;
using YLB.Model;

namespace YLB.Dao
{
    public class UserDao : IUserDao
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        public bool Login(string userName, string passWord)
        {
            List<UserModel> listUser = new UserModel().Users;
            bool res = false;
            foreach (UserModel u in listUser)
            {
                if (userName == u.UserName && passWord == u.PassWord)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }
    }
}
