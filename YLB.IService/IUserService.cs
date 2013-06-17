using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YLB.IService
{
    /// <summary>
    /// 创建人：℡乄℡瞬间：http://www.github.com/yksoft/springdemo
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// 获取字符串
        /// </summary>
        bool Login(string userName, string passWord);
    }
}
