using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace Test
{
    /// <summary>
    /// 创建人：℡乄℡瞬间：http://www.github.com/yksoft/springdemo
    /// 前台页面基类
    /// </summary>
    public class BasePage : Page
    {
        protected override void OnInit(EventArgs e)
        {
            //调用注册方法注册脚本/样式块
            RegisterIncScriptBlock();
            base.OnInit(e);
        }
        /// <summary>
        /// 转到登陆
        /// </summary>
        public void GoLogin()
        {
            //这里可以编写登出代码
            Response.Redirect("/Login.aspx");
        }
        /// <summary>
        /// 弹出消息框
        /// </summary>
        public void Alert(string message)
        {
           ScriptManager.RegisterStartupScript((Page)HttpContext.Current.CurrentHandler, typeof(Page), " ", "alert('" + message + "');", true);
        }
        /// <summary>
        /// 输出JavaScript
        /// </summary>
        /// <param name="strScript"></param>
        public void InvokeScript(string strScript)
        {
            ScriptManager.RegisterStartupScript((Page)HttpContext.Current.CurrentHandler, typeof(Page), " ", strScript, true);
        }
        /// <summary>
        /// 刷新当前页面(防止重复提交，这里用了转向，没用使用reload)
        /// </summary>
        public void RefreshPage()
        {
            string url = Request.Url.ToString();
            ScriptManager.RegisterStartupScript((Page)HttpContext.Current.CurrentHandler, typeof(Page), " ", "window.location='" + url + "';", true);
        }
        /// <summary>
        /// 注册INC脚本块
        /// </summary>
        public void RegisterIncScriptBlock()
        {
            this.Header.Controls.AddAt(1, RegistJavaScript("/js/js.js"));
            this.Header.Controls.AddAt(2, RegistCSS("/css/css.css"));
        }

        /// <summary>
        /// 构建JS引用 
        /// HtmlGenericControl--定义不由特定的 .NET Framework 类表示的所有 HTML 服务器控件元素的方法、属性和事件，例如<script>、<span>、<div>、<body> 或 <font>
        /// </summary>
        /// <param name="src">js文件地址</param>
        /// <returns></returns>
        public HtmlGenericControl RegistJavaScript(string src)
        {
            HtmlGenericControl hgc = new HtmlGenericControl("script");
            hgc.Attributes["type"] = "text/javascript";
            hgc.Attributes["src"] = src;
            return hgc;
        }

        /// <summary>
        /// 构建CSS样式引用
        /// HtmlLink--允许编程访问服务器上的 HTMLlink 元素
        /// </summary>
        /// <param name="href">css文件地址</param>
        /// <returns></returns>
        public HtmlLink RegistCSS(string href)
        {
            HtmlLink hl = new HtmlLink();
            hl.Href = href;
            hl.Attributes["rel"] = "stylesheet";
            hl.Attributes["type"]="text/css";           
            hl.Attributes["href"] = href;
            return hl;
        }
        /// <summary>
        /// 构建ICo
        /// </summary>
        /// <returns></returns>
        public HtmlLink RegistIco()
        {
            HtmlLink hl = new HtmlLink();
            hl.Attributes["rel"] = "icon";
            hl.Attributes["href"] = "/logo.ico";
            hl.Attributes["type"] = "image/x-icon";
            return hl;
        }
    }
}
