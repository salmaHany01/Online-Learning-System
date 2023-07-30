using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLearningSystem
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            success_pay_panel.Visible = false;
            PaymentPanel.Visible = true;

        }
        protected void payment_btn_Click(object sender, EventArgs e)
        {
            userServiceRef.IwcfUserClient user = new userServiceRef.IwcfUserClient();
            bool isValid = false;
            long card_num = long.Parse(card_number.Text);
            int cvv = int.Parse(security_code.Text);
            int ex_month = int.Parse(expiry_month.Text);
            int ex_year = int.Parse(expiryYear.Text);
            isValid = user.isValidCreditCard(card_num, cvv, ex_month, ex_year);
            if (isValid)
            {
                error_lbl.Visible = false;
                string enrollemnet_date = (DateTime.Today).ToString();
                user.action_to_validCard(LoginForm.tokenUser);
                success_pay_panel.Visible = true;
                PaymentPanel.Visible = false;
            }
            else
            {
                error_lbl.Text = "Credit card details were incorrect. Please try again.";
                error_lbl.Visible = true;
                success_pay_panel.Visible = false;
                PaymentPanel.Visible = true;
            }
        }

        protected void back_to_homepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}