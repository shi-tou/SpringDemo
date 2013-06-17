using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLB.IDao
{
    public interface IUserDao
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        bool Login(string userName, string passWord);
    }
}
