using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Configuration;

namespace YLB.Common
{
    public class Config
    {
        #region 属性
        /// <summary>
        /// 表示可通过键或索引访问的关联 String 键和 String 值的集合。 
        /// </summary>
        public static NameValueCollection nvc;
        /// <summary>
        /// 包含 KeyValueConfigurationElement 对象的集合
        /// </summary>
        public static KeyValueConfigurationCollection kvc;
        /// <summary>
        /// 实例
        /// </summary>
        public static Config instance;
        /// <summary>
        /// 锁对象
        /// </summary>
        private object o = new object();
        /// <summary>
        /// 值
        /// </summary>
        public static string serviceConfig;
        #endregion

        /// <summary>
        /// 获取实例方法(静态方法)
        /// </summary>
        /// <returns></returns>
        public static Config GetInstance()
        {
            if (instance == null)
            {
                //ConfigurationManager--提供对客户端应用程序配置文件的访问
                //AppSettins--获取当前应用程序默认配置的 AppSettingsSection 数据
                nvc = ConfigurationManager.AppSettings;
                //初始化实例
                instance = new Config();
            }
            return instance;
        }
        /// <summary>
        /// 索引--获取配置中指定键值
        /// </summary>
        public string this[string key]
        {
            get
            {
                lock (o)
                {
                    if (key == "ServiceConfig")
                    {
                        return serviceConfig;
                    }
                    else if (nvc == null)
                    {
                        return kvc[key].Value;
                    }
                    else
                    {
                        return nvc[key];
                    }
                }
            }
        }
        /// <summary>
        /// 获取配置中的数值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetInt(string key)
        {
            string v = this[key];
            int ret = 0;
            try
            {
                ret = Convert.ToInt32(v);
            }
            catch { }
            return ret;
        }
        /// <summary>
        /// 获取配置中的布尔值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool GetBool(string key)
        {
            string v = this[key];
            bool ret = false;
            try
            {
                ret = Convert.ToBoolean(v);
            }
            catch { }
            return ret;
        }
    }
}
