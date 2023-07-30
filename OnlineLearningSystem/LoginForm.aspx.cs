using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLearningSystem
{
    public partial class LoginForm : System.Web.UI.Page
    {
        string invalidParam = "Invalid input parameters";
        string invalidEaP = "Invalid email or password";
        public static string tokenUser = "";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("MainPage.aspx");
            
        }

        protected void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {

        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            userServiceRef.IwcfUserClient s = new userServiceRef.IwcfUserClient();
            string mess = s.LoginUser(txt_emailL.Text, txt_passL.Text);
            if (txt_emailL.Text.Equals("admin@gmail.com") && txt_passL.Text.Equals("admin"))
            {
                Response.Redirect("AdminForm.aspx");
            }
            else {
                if (mess.Equals(invalidParam))
                {
                    error_lbl.Text = invalidParam;
                    error_lbl.Visible = true;
                }
                else if (mess.Equals(invalidEaP) || mess.Contains("Error"))
                {
                    error_lbl.Text = invalidEaP;
                    error_lbl.Visible = true;
                }
                else
                {
                    tokenUser = mess;
                    Response.Redirect("MainPage.aspx");
                }
            }
            


        }
    }
}