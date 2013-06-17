using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLB.IService
{
    public interface IUserService
    {
        /// <summary>
        /// 获取字符串
        /// </summary>
        bool Login(string userName, string passWord);
    }
}
