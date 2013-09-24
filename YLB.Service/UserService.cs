using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YLB.Dao;

namespace YLB.Service
{
    public class UserService : BaseService, IUserService
    {
        private IUserDao userDao
        {
            set;
            get;
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public int Login(string userName, string passWord)
        {
            DataTable dt = userDao.GetDataTable("T_User", "*", "UserName='" + userName + "'");
            if (dt.Rows.Count == 0)
            {
                return 1;
            }
            if (dt.Rows[0]["PassWord"].ToString() != passWord)
            {
                return 2;
            }
            return 0;
        }
    }
}
