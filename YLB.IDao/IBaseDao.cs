using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace YLB.IDao
{
    /// <summary>
    /// 数据访问基类接口
    /// </summary>
    public interface IBaseDao
    {
        #region Insert/Update/Delete
        /// <summary>
        /// 插入记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dt">记录数据表。表中字段名必须与数据中字段名一致</param>
        /// <returns>影响记录数</returns>
        int Insert(string tableName, DataTable dt);
        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dt">记录数据表。表中字段名必须与数据中字段名一致</param>
        /// <returns>影响记录数</returns>
        int Update(string tableName, DataTable dt, string where);
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        int Delete(string tableName);
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="where">删除条件</param>
        /// <returns></returns>
        int Delete(string tableName, string where);
        #endregion

        #region DataSet
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>DataSet结果集</returns>
        DataSet GetDataSet(string tableName);
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataSet结果集</returns>
        DataSet GetDataSet(string tableName, string fields);
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <param name="where">查询条件</param>
        /// <returns>DataSet结果集</returns>
        DataSet GetDataSet(string tableName, string fields,string where);
        #endregion

        #region DataTable
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>DataTable表数据</returns>
        DataTable GetDataTable(string tableName);
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataTable表数据</returns>
        DataTable GetDataTable(string tableName, string fields);
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <param name="where">查询条件</param>
        /// <returns>DataTable表数据</returns>
        DataTable GetDataTable(string tableName, string fields,string where);
        #endregion

        #region 执行Sql语句
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>影响记录数</returns>
        int ExecteSql(CommandType cType, string sql);
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>结果集DataSet</returns>
        DataSet ExecteSqlGetDataSet(CommandType cType, string sql);
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>表数据DataTable</returns>
        DataTable ExecteSqlGetDataTable(CommandType cType, string sql);
        #endregion
    }
}
