using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DB15
{
    public partial class 首頁 : System.Web.UI.Page
    {
        SqlConnection Conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;User ID=DB15;Password=DB15");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Robot.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Web.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Text1.Visible = true;
            Button2.Visible = true;
            
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Text1.Value == "111")
            {
                Response.Redirect("Expert.aspx");
            }
            else { Response.Write("<script>alert('密碼有誤，請再試一次');  </script>"); }
        }
    }
}