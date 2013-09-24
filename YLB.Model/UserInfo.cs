using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLB.Model
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class UserInfo
    {
        private int id;
        private string userName;
        private string passWord;
        /// <summary>
        /// 用户ID
        /// </summary>
        public int ID
        {
            set { value = id; }
            get { return id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { value = userName; }
            get { return userName; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string PassWord
        {
            set { value = passWord; }
            get { return passWord; }
        }
        /// <summary>
        /// 模拟用户数据，用于测试
        /// </summary>
        public List<UserInfo> Users
        {
            get
            {
                List<UserInfo> listUser = new List<UserInfo>();
                for (int i = 0; i < 10; i++)
                {
                    UserInfo u = new UserInfo();
                    u.id = i + 1;
                    u.userName = "admin" + (i + 1).ToString();
                    u.passWord = "admin" + (i + 1).ToString();
                    listUser.Add(u);
                }
                return listUser;
            }
        }

    }
}
