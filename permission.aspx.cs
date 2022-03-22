using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Allforms.pages
{     
    public partial class permission : System.Web.UI.Page
    { 
        classes cs = new classes(); string sql = "";DataTable dt; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
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
            sql = "Select * from tbl_titles";
            dt = cs.select(sql);
            if(dt!=null && dt.Rows.Count >0)
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
        protected void btnedit_Click(object sender, EventArgs e)
        {
            int rowid = ((GridViewRow)((LinkButton)sender).Parent.Parent).RowIndex;
            string Id = Gvdetail.DataKeys[rowid]["id"].ToString();
            ViewState["Cid"] = Id;
            //string title = ""; string body = "";
            //ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup('" + title + "', '" + body + "');", true);
            mpshiv.Show();
        }
        protected void btnupdate_Click1(object sender, EventArgs e)
        {
            
            if (ViewState["Cid"] != null)
            {                   
                sql = "Update tbl_titles set [msg]='" + txttransid.Text + "', IsActive='" + chkpermission.Checked + "' where id='"+ ViewState["Cid"] .ToString()+ "' " ;
                cs.update(sql);
                string temp2s = "alertify.notify(`Update Record `, 'success', 3, function(){  console.log('dismissed'); });";
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "alert4", temp2s, true);
            }
            else
            {
                string temp2s = "alertify.notify(`Closed Modal Popup.Again Edit Forms `, 'error', 3, function(){  console.log('dismissed'); });";
                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "alert4", temp2s, true);
            }
          
        }

        protected void Gvdetail_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string payid = DataBinder.Eval(e.Row.DataItem, "isactive").ToString();
                Panel pnlstatus = e.Row.FindControl("divrates") as Panel;
                if (payid.ToLower().Trim().ToLower() == "true")
                    pnlstatus.Attributes.Add("class", "progress-bar bg-danger");
                else
                    pnlstatus.Attributes.Add("class", "progress-bar bg-success");
            }
        }
    }
}