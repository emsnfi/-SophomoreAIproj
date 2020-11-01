using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace DB15

{
    public partial class Robot : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");

        SqlCommand cmd = null;
        SqlCommand cmd1 = null;

        String T = "0";//Type 1:電競 2:文書
        string plus = "";
        string sSql = "";
        int N = 0;
        String S1 = "0";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) Session["N"] = "1";

        }

        protected void Button1_Click(object sender, EventArgs e)
        { //電競筆電
            Session["T1"] = "1";
            sSql = "select G_Model AS 筆電型號, G_Processor AS 處理器 ,G_RAM,G_HD AS 硬碟, G_VGA AS 顯示器 ,G_Size AS 螢幕大小 , G_Price AS 價格 , G_URL AS 購買網址 from GAME ";
            conn.Open();
            cmd = new SqlCommand(sSql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;

            GridView1.DataBind();

            dr.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            GridView1.Visible = true;
            Button4.Text = "2萬~3萬";
            Button5.Text = "3萬~4萬";
            Button6.Text = "5萬以上";
            select2.Visible = true;
            Button21.Visible = false;
            Button22.Visible = true;
            Button23.Visible = true;

        }
        protected void Button2_Click(object sender, EventArgs e)
        { // 文書筆電
            Session["T1"] = "2";
            sSql = "select  O_Model AS 筆電型號, O_Processor AS 處理器 , O_RAM,O_HD AS 硬碟, O_VGA AS 顯示器 ,O_Size AS 螢幕大小 , O_Price AS 價格 , O_URL AS 購買網址  from OFFICE ";
            conn.Open();
            cmd = new SqlCommand(sSql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;

            GridView1.DataBind();

            dr.Dispose();
            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            GridView1.Visible = true;
            Button4.Text = "1萬以下";
            Button5.Text = "1萬~2萬";
            Button6.Text = "2萬~3萬";
            Button11.Text = "HP";
            Button12.Text = "都可以";
            Button13.Visible = false;
            Button14.Visible = false;
            Button18.Text = "13.3以下";
            Button19.Text = "14";
            Button20.Text = "15.6";
            select2.Visible = true;
            Button22.Visible = true;
            Button23.Visible = true;



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            T = (string)(context.Session["T1"]);

            if (T.Equals("1"))
            {
                plus = " G_Price >=20000 AND G_Price <=30000";
                sSql = "SELECT  G_Model AS 筆電型號, G_Processor AS 處理器 ,G_RAM AS RAM,G_HD AS 硬碟, G_VGA AS 顯示器 ,G_Size AS 螢幕大小 , G_Price AS 價格 , G_URL AS 購買網址 FROM GAME WHERE " + plus + "";
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select3.Visible = true;
                Session["S1"] = sSql;

            }

            if (T.Equals("2"))
            {
                plus = "O_Price <=10000";
                sSql = "select O_Model AS 筆電型號, O_Processor AS 處理器 , O_RAM AS RAM,O_HD AS 硬碟, O_VGA AS 顯示器 ,O_Size AS 螢幕大小 , O_Price AS 價格 , O_URL AS 購買網址  from OFFICE WHERE " + plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select3.Visible = true;
                Session["S1"] = sSql;
            }


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = " G_Price >=30000 AND G_Price <=40000";
                sSql = "select  G_Model AS 筆電型號, G_Processor AS 處理器 ,G_RAM AS RAM,G_HD AS 硬碟, G_VGA AS 顯示器 ,G_Size AS 螢幕大小 , G_Price AS 價格 , G_URL AS 購買網址  from GAME WHERE " + plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select3.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "O_Price >=10000 AND O_Price <=20000";
                sSql = "select  O_Model AS 筆電型號, O_Processor AS 處理器 , O_RAM AS RAM,O_HD AS 硬碟, O_VGA AS 顯示器 ,O_Size AS 螢幕大小 , O_Price AS 價格 , O_URL AS 購買網址  from OFFICE WHERE " + plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select3.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            T = (string)(context.Session["T1"]);

            if (T.Equals("1"))
            {
                plus = " G_Price >=50000";
                sSql = "select  G_Model AS 筆電型號, G_Processor AS 處理器 ,G_RAM AS RAM,G_HD AS 硬碟, G_VGA AS 顯示器 ,G_Size AS 螢幕大小 , G_Price AS 價格 , G_URL AS 購買網址  from GAME WHERE " + plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select3.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "O_Price >=20000 AND O_Price <=30000";
                sSql = "select  O_Model AS 筆電型號, O_Processor AS 處理器 , O_RAM AS RAM,O_HD AS 硬碟, O_VGA AS 顯示器 ,O_Size AS 螢幕大小 , O_Price AS 價格 , O_URL AS 購買網址  from OFFICE WHERE " + plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select3.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            if (T.Equals("1")) { sSql = "select  G_Model AS 筆電型號, G_Processor AS 處理器 ,G_RAM AS RAM,G_HD AS 硬碟, G_VGA AS 顯示器 ,G_Size AS 螢幕大小 , G_Price AS 價格 , G_URL AS 購買網址  from GAME"; }
            if (T.Equals("2")) { sSql = "select  O_Model AS 筆電型號, O_Processor AS 處理器 , O_RAM AS RAM,O_HD AS 硬碟, O_VGA AS 顯示器 ,O_Size AS 螢幕大小 , O_Price AS 價格 , O_URL AS 購買網址  from GAME"; }
            select3.Visible = true;
            Session["S1"] = sSql;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Model like'%ACER%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
 if (dr.Read()) {  }
                else { Label9.Visible = true; }
                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
               
                select4.Visible = true;
                Session["S1"] = sSql;

            }

            if (T.Equals("2"))
            {
                plus = "AND O_Model like'%ACER%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
if (dr.Read()) { }
                else { Label9.Visible = true; }
                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                
                select4.Visible = true;
                Session["S1"] = sSql;

            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Model like'%ASUS%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Model like'%ASUS%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Model like'%Lenova%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Model like'%Lenova%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Model like'%Dell%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Model like'%HP%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }
        }


        protected void Button12_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Model like'%MSI%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                select4.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Model like'%GIGABYTE%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select4.Visible = true;
                Session["S1"] = sSql;
            }


        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            select4.Visible = true;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Processor like'%i5%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select5.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Processor like'%i5%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select5.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Processor like'%i7%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select5.Visible = true;
                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Processor like'%i7%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();

                select5.Visible = true;
                Session["S1"] = sSql;
            }
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            select5.Visible = true;
        }

        protected void Button18_Click(object sender, EventArgs e)
        {

            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Size like'%15.6%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();


                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Processor like'%13.3%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();


                Session["S1"] = sSql;
            }
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);
            if (T.Equals("1"))
            {
                plus = "AND G_Size like'%17.3%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();


                Session["S1"] = sSql;
            }

            if (T.Equals("2"))
            {
                plus = "AND O_Processor like'%14%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();


                Session["S1"] = sSql;
            }
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            HttpContext context = HttpContext.Current;
            sSql = (string)(context.Session["S1"]);
            T = (string)(context.Session["T1"]);


            if (T.Equals("2"))
            {
                plus = "AND O_Processor like'%15.6%'";
                sSql += plus;
                conn.Open();
                cmd = new SqlCommand(sSql, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                GridView1.DataSource = dr;

                GridView1.DataBind();
                if (dr.Read()) { }
                else { Label9.Visible = true; }

                dr.Dispose();
                cmd.Dispose();
                conn.Close();
                conn.Dispose();


                Session["S1"] = sSql;
            }
        }

        protected void Button21_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            Response.Redirect("Robot.aspx");
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            Response.Redirect("首頁.aspx");
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            Image6.Visible = true;
            Label4.Visible = true;
            conn.Open();

            String sSql1 = "";
            sSql1 = "SELECT Know_Text FROM KNOW1 WHERE Know_ID='" + Session["N"] + "'";
            int n = Int32.Parse(Session["N"].ToString()) + 1;
            Session["N"] = n.ToString();
            cmd1 = new SqlCommand(sSql1, conn);


            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                Label4.Text = dr1.GetString(0);
            }
            else
            {
                Session["N"] = "1";
                dr1.Close();
                sSql1 = "SELECT Know_Text FROM KNOW1 WHERE Know_ID=1";
                cmd1 = new SqlCommand(sSql1, conn);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    Label4.Text = dr.GetString(0);
                }
            }


        }
    }


}