using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLB.IDao
{
    /// <summary>
    /// 创建人：℡乄℡瞬间：http://www.github.com/yksoft/springdemo
    /// </summary>
    public interface IUserDao
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        bool Login(string userName, string passWord);
    }
}
