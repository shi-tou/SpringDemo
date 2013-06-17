using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YLB.IService;

namespace Test
{
    public partial class Login : System.Web.UI.Page
    {
        //注入
        public IUserService UserService
        {
            set;
            get;
        }

        /// <summary>
        /// 加载事件
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 登录
        /// </summary>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserService.Login(this.txtUserName.Text, this.txtPassWord.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), " ", "window.location='default.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), " ", "alert('账号/密码不正确！')", true);
            }
        }
    }
}
