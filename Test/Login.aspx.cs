using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YLB.Service;

namespace Test
{
    public partial class Login : System.Web.UI.Page
    {
        //注入
        private IUserService userService;
        public IUserService UserService
        {
            set { userService = value; }
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
            int res = userService.Login(this.txtUserName.Text, this.txtPassWord.Text);
            if (res == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), " ", "window.location='default.aspx';", true);
            }
            else if (res == 1)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), " ", "alert('用户名不存在！')", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), " ", "alert('密码不正确！')", true);
            }
        }
    }
}
