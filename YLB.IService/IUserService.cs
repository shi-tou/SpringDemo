using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YLB.IService
{
    public interface IUserService : IBaseService
    {
        /// <summary>
        /// 0-登录成功;1-用户名不存在;2-密码不正确
        /// </summary>
        int Login(string userName, string passWord);
    }
}
