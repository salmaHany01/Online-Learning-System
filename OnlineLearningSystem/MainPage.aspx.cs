using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLearningSystem
{
    public partial class MainPage : System.Web.UI.Page
    {
        public static int selected_course_id=0;
        protected void Page_Load(object sender, EventArgs e)
        {
            error_lbl.Visible = false;
            userServiceRef.IwcfUserClient s = new userServiceRef.IwcfUserClient();
            time_display.Text = "Current Date and Time: " + s.getEnrollmentDate_pattern();
            DataTable dtbl = new DataTable();

            List<userServiceRef.Course> cs = s.ViewCourses().ToList();
            dtbl.Columns.Add("courseID");
            dtbl.Columns.Add("name");
            dtbl.Columns.Add("professor");
            dtbl.Columns.Add("description");
            dtbl.Columns.Add("price");
            dtbl.Columns.Add("duration");
            dtbl.Columns.Add("rating");


            foreach (var course in cs)
            {
                DataRow row = dtbl.NewRow();

                row["courseID"] = course.id;
                row["name"] = course.name;
                row["professor"] = course.prof;
                row["description"] = course.desc;
                row["price"] = course.price;
                row["duration"] = course.duration;
                row["rating"] = course.rating;

                dtbl.Rows.Add(row);
            }
            GridView GridView1 = Page.FindControl("grid_view") as GridView;
            GridView1.Visible = true;
            GridView1.DataSource = dtbl;
            GridView1.DataBind();
        }

      
        protected void grid_view_SelectedIndexChanged(object sender, EventArgs e)
        { 
            GridView GridView1 = Page.FindControl("grid_view") as GridView;
            GridViewRow selected_row = GridView1.SelectedRow;
            selected_course_id = int.Parse(selected_row.Cells[1].Text);
            
            
        }

     
        protected void add_to_cart_Click(object sender, EventArgs e)
        {
            userServiceRef.IwcfUserClient user = new userServiceRef.IwcfUserClient();
            
            int logged_user = user.GetUserIdFromToken(LoginForm.tokenUser);
            if (selected_course_id == 0)
            {
                //span
                error_lbl.Text = "Please select a course first.";
                error_lbl.Visible = true;
            }
            else
            {
                //span
                error_lbl.Text = "Course is successfully added to cart.";
                error_lbl.Visible = true;
                user.save_to_cart(selected_course_id, logged_user);
            }
            
        }

        protected void view_cart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        protected void logofut_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");
        }
    }
}
