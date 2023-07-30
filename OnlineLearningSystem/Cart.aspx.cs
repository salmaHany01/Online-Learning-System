using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLearningSystem
{
    public partial class Cart : System.Web.UI.Page
    {
        public static int selected_course_id = 0;
        List<int> courses_prices = new List<int>();
        //Lisst<int> cart_ids = new
        protected void Page_Load(object sender, EventArgs e)
        {
            
            userServiceRef.IwcfUserClient s = new userServiceRef.IwcfUserClient();
          
            DataTable dtbl = new DataTable();

            List<userServiceRef.Course> cs = s.ViewCart(LoginForm.tokenUser).ToList();
            //print token 
            //l_token.Text = "token" + (LoginForm.tokenUser).ToString();
            //print id
            //l_id.Text = "token" + (s.GetUserIdFromToken(LoginForm.tokenUser)).ToString();

            dtbl.Columns.Add("courseID");
            dtbl.Columns.Add("name");
            dtbl.Columns.Add("price");
            foreach (var course in cs)
            {
                DataRow row = dtbl.NewRow();

                row["courseID"] = course.id;
                row["name"] = course.name;
                row["price"] = course.price;

                courses_prices.Add(course.price);
                dtbl.Rows.Add(row);
            }
            GridView GridView1 = Page.FindControl("cart_grid") as GridView;
            GridView1.Visible = true;
            GridView1.DataSource = dtbl;
            GridView1.DataBind();
            total_price.Text = "Total Cart Price: "+ calc_total().ToString();
            
        }

        protected void proceed_btn_Click(object sender, EventArgs e)
        {
            //send the cart_id kman
            Response.Redirect("PaymentPage.aspx");
        }
        public int calc_total() {
            int total=0;
            foreach(var x in courses_prices) {
                total += x;
            }
            return total;
        }

        protected void cart_grid_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView GridView1 = Page.FindControl("cart_grid") as GridView;
            GridViewRow selected_row = GridView1.SelectedRow;
            selected_course_id = int.Parse(selected_row.Cells[1].Text);
        }

        protected void delete_item_btn_Click(object sender, EventArgs e)
        {
            userServiceRef.IwcfUserClient user = new userServiceRef.IwcfUserClient();
            user.delete_item(selected_course_id);
            Response.Redirect("Cart.aspx");
        }
    }
}