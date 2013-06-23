using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using YLB.IService;
using YLB.IDao;

namespace YLB.Service
{
    public class BaseService : IBaseService
    {
        public IBaseDao BaseDao
        {
            set;
            get;
        }
        #region Insert/Update/Delete
        /// <summary>
        /// 插入记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dt">记录数据表。表中字段名必须与数据中字段名一致</param>
        /// <returns>影响记录数</returns>
        public int Insert(string tableName, DataTable dt)
        {
            return BaseDao.Insert(tableName, dt);
        }
        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dt">记录数据表。表中字段名必须与数据中字段名一致</param>
        /// <returns>影响记录数</returns>
        public int Update(string tableName, DataTable dt, string where)
        {
            return BaseDao.Update(tableName, dt, where);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public int Delete(string tableName)
        {
            return Delete(tableName);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="where">删除条件</param>
        /// <returns></returns>
        public int Delete(string tableName, string where)
        {
            return Delete(tableName, where);
        }
        #endregion

        #region DataSet
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>DataSet结果集</returns>
        public DataSet GetDataSet(string tableName)
        {
           return BaseDao.GetDataSet(tableName);
        }
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataSet结果集</returns>
        public DataSet GetDataSet(string tableName, string fields)
        {
            return BaseDao.GetDataSet(tableName,fields);
        }
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <param name="where">查询条件</param>
        /// <returns>DataSet结果集</returns>
        public DataSet GetDataSet(string tableName, string fields, string where)
        {
            return BaseDao.GetDataSet(tableName, fields, where);
        }
        #endregion

        #region DataTable
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>DataTable表数据</returns>
        public DataTable GetDataTable(string tableName)
        {
           return BaseDao.GetDataTable(tableName);
        }
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataTable表数据</returns>
        public DataTable GetDataTable(string tableName, string fields)
        {
            return BaseDao.GetDataTable(tableName,fields);
        }
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <param name="where">查询条件</param>
        /// <returns>DataTable表数据</returns>
        public DataTable GetDataTable(string tableName, string fields, string where)
        {
            return BaseDao.GetDataTable(tableName, fields, where);
        }
        #endregion

        #region 执行Sql语句
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>影响记录数</returns>
        public int ExecteSql(CommandType cType, string sql)
        {
            return BaseDao.ExecteSql(cType, sql);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>结果集DataSet</returns>
        public DataSet ExecteSqlGetDataSet(CommandType cType, string sql)
        {
            return BaseDao.ExecteSqlGetDataSet(cType, sql);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>表数据DataTable</returns>
        public DataTable ExecteSqlGetDataTable(CommandType cType, string sql)
        {
            return BaseDao.ExecteSqlGetDataTable(cType, sql);
        }
        #endregion
    }
}
