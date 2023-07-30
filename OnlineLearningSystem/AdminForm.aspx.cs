using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLearningSystem
{
    public partial class AdminForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            reload();
        }

        protected void course_grid_SelectedIndexChanged1(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            GridView GridView1 = Page.FindControl("course_grid") as GridView;
            GridViewRow row = GridView1.SelectedRow;

            id_txt.Text = row.Cells[0].Text;
            txt_name.Text = row.Cells[1].Text;
            txt_prof.Text = row.Cells[2].Text;
            txt_desc.Text = row.Cells[3].Text.Equals("&nbsp;") ? " " : row.Cells[3].Text;
            txt_price.Text = row.Cells[4].Text;
            txt_duration.Text = row.Cells[5].Text;
            txt_rating.Text = row.Cells[6].Text.Equals("&nbsp;") ? " " : row.Cells[6].Text;            
        }

        protected void btn_edit_Click(object sender, EventArgs e)
        {
            AdminService.AdminSrvSoapClient s = new AdminService.AdminSrvSoapClient();
            GridView GridView1 = Page.FindControl("course_grid") as GridView;

            if (validation())
            {
                s.updateCourse(int.Parse(id_txt.Text), txt_name.Text,
                    txt_prof.Text, txt_desc.Text, int.Parse(txt_price.Text),
                     txt_duration.Text, int.Parse(txt_rating.Text));
                clearFields();
                reload();
                error_lbl.Visible = false;
            }
            else
            {
                error_lbl.Visible = true;
            }
        }

        protected bool validation()
        {
            if (txt_name.Text.Trim().Equals("") || txt_prof.Text.Trim().Equals("") || txt_price.Text.Trim().Equals("") 
                || txt_duration.Text.Trim().Equals(""))
            {
                error_lbl.Text = "Error you have to fill the empty fields";
                return false;
            }

            if(int.Parse(txt_rating.Text) > 5 || int.Parse(txt_rating.Text) < 0)
            {
                error_lbl.Text = "Rating must be smaller than 5 and bigger than 0";
                return false;
            }
            return true;
        }
        
        protected void clearFields()
        {
            id_txt.Text = "";
            txt_desc.Text = "";
            txt_name.Text = "";
            txt_prof.Text = "";
            txt_price.Text = "";
            txt_rating.Text = "";
            txt_duration.Text = "";
        }

        protected void reload()
        {
            AdminService.AdminSrvSoapClient s = new AdminService.AdminSrvSoapClient();
            DataTable dtbl = s.getCourses2();
            course_grid.DataSource = dtbl;
            course_grid.DataBind();
            btn_add.Enabled = true;
        }

        protected void course_grid_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }

        protected void course_grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridView GridView1 = Page.FindControl("course_grid") as GridView;
            GridViewRow row = GridView1.Rows[e.RowIndex];
            AdminService.AdminSrvSoapClient s = new AdminService.AdminSrvSoapClient();
            s.deleteCourse(int.Parse(row.Cells[0].Text));
            reload();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                AdminService.AdminSrvSoapClient s = new AdminService.AdminSrvSoapClient();
                s.addCourse(txt_name.Text,
                    txt_prof.Text, txt_desc.Text, int.Parse(txt_price.Text),
                     txt_duration.Text, int.Parse(txt_rating.Text));
                clearFields();
                reload();
                error_lbl.Visible = false;
            }
            else
            {
                error_lbl.Visible = true;
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginForm.aspx");
        }
    }
}