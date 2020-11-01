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
    public partial class Expertadd : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");
        SqlConnection conn2 = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");
        SqlCommand cmd = null;
        SqlCommand cmd2 = null;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String mo = TextBox1.Text; // 型號
            String pr = TextBox2.Text; //處理器
            String ram = TextBox3.Text; // ram
            String hd = TextBox4.Text; //硬碟大小
            String vg = TextBox5.Text; // 顯示卡規格
            String si = TextBox6.Text;  // 螢幕大小
            String pi = TextBox7.Text;
            String ur = TextBox8.Text;   // 網址
            int price = Int32.Parse(pi);
            conn.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO GAME(G_Model,G_Processor,G_RAM,G_HD,G_VGA,G_Size,G_Price,G_URL) VALUES(@ColumnName2, @ColumnName3, @ColumnName4, @ColumnName5, @ColumnName6,@ColumnName7,@ColumnName8,@ColumnName9)", conn);

            insert.Parameters.AddWithValue("@ColumnName2", TextBox1.Text);
            insert.Parameters.AddWithValue("@ColumnName3", TextBox2.Text);
            insert.Parameters.AddWithValue("@ColumnName4", TextBox3.Text);
            insert.Parameters.AddWithValue("@ColumnName5", TextBox4.Text);
            insert.Parameters.AddWithValue("@ColumnName6", TextBox5.Text);
            insert.Parameters.AddWithValue("@ColumnName7", TextBox6.Text);
            insert.Parameters.AddWithValue("@ColumnName8", price);
            insert.Parameters.AddWithValue("@ColumnName9", TextBox8.Text);

            insert.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}