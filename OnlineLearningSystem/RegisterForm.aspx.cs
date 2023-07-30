using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLearningSystem
{
    public partial class RegisterForm : System.Web.UI.Page
    {
        string errorMessage = "User already exists";
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                userServiceRef.IwcfUserClient s = new userServiceRef.IwcfUserClient();
                string mess = s.RegisterUser(txt_usernameR.Text, txt_emailR.Text, txt_passR.Text);

                if (!mess.Equals(errorMessage))
                {
                    Response.Redirect("~/LoginForm.aspx");
                }
                else
                {
                    error_lbl.Text = errorMessage + ", please try again";
                    error_lbl.Visible = true;
                }

            }
            else
            {
                error_lbl.Visible = true;
            }

        }

        public void clearFields()
        {
            txt_usernameR.Text = "";
            txt_emailR.Text = "";
            txt_passR.Text = "";      
        }

        protected bool validation()
        {
            if (txt_usernameR.Text.Trim().Equals("") || txt_emailR.Text.Trim().Equals("") || txt_passR.Text.Trim().Equals(""))
            {
                error_lbl.Text = "Error you have to fill the empty fields";
                return false;
            }
            return true;
        }




    }
}