using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLB.Model
{
    /// <summary> 
    /// 创建人：℡乄℡瞬间：http://www.github.com/yksoft/springdemo
    /// 用户实体
    /// </summary>
    public class UserModel
    {
        private int userID;
        private string userName;
        private string passWord;
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            set { value = userID; }
            get { return userID; }
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
        public List<UserModel>Users
        {
            get 
            {
                List<UserModel> listUser = new List<UserModel>();
                for(int i=0; i<10 ; i++)
                {
                    UserModel u=new UserModel();
                    u.userID = i + 1;
                    u.userName = "admin" + (i + 1).ToString();
                    u.passWord = "admin" + (i + 1).ToString();
                    listUser.Add(u);
                }
                return listUser;
                    
            }
        }

    }
}
