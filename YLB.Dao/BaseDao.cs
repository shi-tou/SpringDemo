using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Data.Core;
using YLB.IDao;
using System.Data;
using Spring.Data.Common;

namespace YLB.Dao
{
    /// <summary>
    /// 数据访问基类
    /// </summary>
    public class BaseDao :AdoDaoSupport, IBaseDao
    {
        #region Insert/Update/Delete
        /// <summary>
        /// 插入记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dt">记录数据表。表中字段名必须与数据中字段名一致</param>
        /// <returns>影响记录数</returns>
        public int Insert(string tableName, DataTable dt)
        {
            StringBuilder sbSql = new StringBuilder();
            StringBuilder sbFidle = new StringBuilder();
            StringBuilder sbValue = new StringBuilder();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i != 0)
                {
                    sbFidle.Append(",");
                    sbFidle.Append(",");
                }
                sbFidle.AppendFormat("[{0}]", dt.Columns[i].ColumnName);
                sbValue.Append(dt.Rows[0][i].ToString());
            }
            sbSql.AppendFormat("insert into {0} ({1}) values ({2})", tableName, sbFidle, sbValue);
            return AdoTemplate.ExecuteNonQuery(CommandType.Text, sbSql.ToString());
        }
        /// <summary>
        /// 修改记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="dt">记录数据表。表中字段名必须与数据中字段名一致</param>
        /// <returns>影响记录数</returns>
        public int Update(string tableName, DataTable dt, string where)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendFormat("update {0} set ", tableName);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i != 0)
                {
                    sbSql.Append(",");
                }
                sbSql.AppendFormat("[{0}]='{1}'", dt.Columns[i].ColumnName, dt.Rows[0][i].ToString());
            }
            sbSql.AppendFormat(" where {0}", where);
            return AdoTemplate.ExecuteNonQuery(CommandType.Text, sbSql.ToString());
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public int Delete(string tableName)
        {
            return Delete(tableName, "");
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="where">删除条件</param>
        /// <returns></returns>
        public int Delete(string tableName, string where)
        {
            StringBuilder sbSql = new StringBuilder();
            if (where == "")
                sbSql.AppendFormat("delete from {0}", tableName);
            else
                sbSql.AppendFormat("delete from {0} where {1}", tableName, where);
            return AdoTemplate.ExecuteNonQuery(CommandType.Text, sbSql.ToString());
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="where">删除条件</param>
        /// <returns></returns>
        public int Delete(string tableName, string keycol, object obj)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendFormat("delete from {0} where {1}=@{1}", tableName, keycol);
            IDbParameters param = AdoTemplate.CreateDbParameters();
            param.AddWithValue(keycol, obj);
            return AdoTemplate.ExecuteNonQuery(CommandType.Text, sbSql.ToString(), param);
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
            return GetDataSet(tableName, "*","");
        }
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataSet结果集</returns>
        public DataSet GetDataSet(string tableName, string fields)
        {
            return GetDataSet(tableName, fields, "");
        }
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataSet结果集</returns>
        public DataSet GetDataSet(string tableName, string fields,string where)
        {
            StringBuilder sbSql = new StringBuilder();
            if (where == "")
                sbSql.AppendFormat("select {0} from {1}", fields, tableName);
            else
                sbSql.AppendFormat("select {0} from {1} where {2}", fields, tableName, where);
            return AdoTemplate.DataSetCreate(CommandType.Text, sbSql.ToString());
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
            return GetDataTable(tableName, "*","");
        }
        /// <summary>
        /// 获取DataTable表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataTable表数据</returns>
        public DataTable GetDataTable(string tableName, string fields)
        {
            return GetDataTable(tableName, fields, "");
        }
        /// <summary>
        /// 获取DataSet数据集
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="fields">数据字段，如：string fields="ID,Name,Sex";如为"*",则为所有字段</param>
        /// <returns>DataSet结果集</returns>
        public DataTable GetDataTable(string tableName, string fields, string where)
        {
            StringBuilder sbSql = new StringBuilder();
            if (where == "")
                sbSql.AppendFormat("select {0} from {1}", fields, tableName);
            else
                sbSql.AppendFormat("select {0} from {1} where {2}", fields, tableName, where);
            return AdoTemplate.DataTableCreate(CommandType.Text, sbSql.ToString());
        }
        #endregion

        #region 执行Sql语句
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>影响记录数</returns>
        public int ExecteSql(CommandType cType,string sql)
        {
            return AdoTemplate.ExecuteNonQuery(cType, sql);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>结果集DataSet</returns>
        public DataSet ExecteSqlGetDataSet(CommandType cType, string sql)
        {
            return AdoTemplate.DataSetCreate(CommandType.Text, sql);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="cType">执行类型</param>
        /// <param name="sql">sql语句</param>
        /// <returns>表数据DataTable</returns>
        public DataTable ExecteSqlGetDataTable(CommandType cType, string sql)
        {
            return AdoTemplate.DataTableCreate(CommandType.Text, sql);
        }
        #endregion
    }
}
