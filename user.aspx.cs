using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Allforms.pages
{
    public partial class user : System.Web.UI.Page
    {
        classes cs = new classes();
        string sql = "";
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["dtUser"] != null)
                {
                    Get_user();
                }
                else
                {
                    Response.Redirect("~/pages/default.aspx");
                }
            }
        }
        protected void Get_user()
        {
            sql = "Select * from tbl_user";
            dt = cs.select(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                Gvdetail.DataSource = dt;
                Gvdetail.DataBind();
            }
            else
            {
                Gvdetail.DataSource = null;
                Gvdetail.DataBind();
            }
        }
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            sql = "insert into tbl_user (userid,pass,contact,office,admission,bed_all,login,phd,isActive,enquiry) values('" + user_id.Text + "','" + password.Text + "','" + contact.Text + "','" + DropDownList1.Text + "','" + admision.Checked + "','" + bed_all.Checked + "','" + login.Checked + "','" + phd.Checked + "','" + isactive.Checked + "','" + enquiry.Checked + "' ) ";
            cs.insert(sql);
            empty();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Data Inserted Succesfully')", true);
        }
        public void empty()
        {
            user_id.Text = "";
            password.Text = "";
            contact.Text = "";
            DropDownList1.SelectedIndex = -1;
            admision.Checked = false;
            bed_all.Checked = false;
            login.Checked = false;
            phd.Checked = false;
            isactive.Checked = false;
            enquiry.Checked = false;
        }
        protected void btndelete_Click(object sender, EventArgs e)
        {
            int rowid = ((GridViewRow)((LinkButton)sender).Parent.Parent).RowIndex;
            string Id = Gvdetail.DataKeys[rowid]["PK_id"].ToString();
            ViewState["Cid"] = Id;
            //string title = ""; string body = "";
            //ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);
            sql = "delete from tbl_user  where PK_id= '"+ ViewState["Cid"].ToString() +"' ";
            cs.delete(sql);
        }
        protected void Gvdetail_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string payid = DataBinder.Eval(e.Row.DataItem, "isactive").ToString();
                Panel pnlstatus = e.Row.FindControl("divrates") as Panel;
                //if (payid.ToLower().Trim().ToLower() == "true")
                //    pnlstatus.Attributes.Add("class", "progress-bar bg-danger");
                //else
                //    pnlstatus.Attributes.Add("class", "progress-bar bg-success");
            }
        }
    }
}