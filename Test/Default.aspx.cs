using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YLB.Common;
using System.Text;

namespace Test
{
    public partial class _Default : BasePage
    {
        /// <summary>
        /// Config配置实例
        /// </summary>
        public static Config cfg = Config.GetInstance();
        /// <summary>
        /// 加载事件
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("数据库地址：" + cfg["db.datasource"]);
                sb.Append("<br/>数据库名称：" + cfg["db.database"]);
                Response.Write(sb);
            }
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        protected void Alert_Click(object sender, EventArgs e)
        {
            Alert("弹出消息框！！");
        }
        /// <summary>
        /// 输出js块
        /// </summary>
        protected void Respose_Click(object sender, EventArgs e)
        {
            InvokeScript("alert('输出js块！！')");
        }
        /// <summary>
        /// 退出
        /// </summary>
        protected void LoginOut_Click(object sender, EventArgs e)
        {
            GoLogin();
        }
        /// <summary>
        /// 刷新
        /// </summary>
        protected void Refresh_Click(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }
}
