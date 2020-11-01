using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DB15
{
      
    public partial class Expertkn : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");
        SqlCommand cmd = null;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO KNOW1(Know_Text) VALUES(@ColumnName2)", conn);

            insert.Parameters.AddWithValue("@ColumnName2", TextBox1.Text);
            

            insert.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
            Response.Write("<script>alert('新增成功!');</script>"); 


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Expert.aspx");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}