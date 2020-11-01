using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DB15
{
    public partial class All : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");
            SqlCommand cmd = null;
            conn.Open();
            string sSql = " select O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM,O_HD as 硬碟大小," +
           "O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址 from OFFICE union select G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                     "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址 from GAME";

            cmd = new SqlCommand(sSql, conn);


            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Dispose();
            cmd.Dispose();


            conn.Close();
            conn.Dispose();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Expert.aspx");
        }

       
    }
}