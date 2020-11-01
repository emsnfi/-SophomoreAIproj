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
    public partial class Web : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");
        SqlCommand cmd = null;
            SqlCommand cmd1 = null;
        string of = "SELECT O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址 from OFFICE";
        string ga = "select G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM,G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price,G_URL as 購買網址 from GAME";

        string tes = "of " + "where O_Model like '%ASUS%' and  O_Size like '%15.6%' and (O_Price<20000 and O_Price>10000) ";
                        
        public static int click = 0;
        public static int clicksi = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");
            
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
            if (!IsPostBack) Session["N"] = "1";

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {//種類 
            SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");

            SqlCommand cmd = null;
            SqlCommand cmd1 = null;

            conn.Open();
            if (DropDownList3.Text == "電競筆電")
            {
                click++;
                GridView1.DataSource = null;

                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("----請選擇-----");
                DropDownList2.Items.Add("20000元~40000元");
                DropDownList2.Items.Add("40000元~50000元");
                DropDownList2.Items.Add("50000元以上");

                DropDownList4.Items.Clear();
                DropDownList4.Items.Add("----請選擇-----");
                DropDownList4.Items.Add("15~16吋");
                DropDownList4.Items.Add("16吋以上");

                DropDownList5.Items.Clear();
                DropDownList5.Items.Add("----請選擇-----");
                DropDownList5.Items.Add("ASUS");
                DropDownList5.Items.Add("ACER");
                DropDownList5.Items.Add("DELL");
                DropDownList5.Items.Add("MSI");
                DropDownList5.Items.Add("GIGABYTE");
                DropDownList5.Items.Add("Lenovo");


                string sSql = "select G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM,G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price,G_URL as 購買網址 from GAME";
                cmd = new SqlCommand(sSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Dispose();
                cmd.Dispose();

            }
            else if (DropDownList3.Text == "文書筆電" && click % 2 == 0)
            {
                string sSql = "select O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM,O_HD as 硬碟大小," +
                    "O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址 from OFFICE";
                cmd = new SqlCommand(sSql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Dispose();
                cmd.Dispose();

                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("----請選擇-----");
                DropDownList2.Items.Add("10000元以下");
                DropDownList2.Items.Add("10000元~20000元");
                DropDownList2.Items.Add("20000元以上");

                DropDownList4.Items.Clear();
                DropDownList4.Items.Add("----請選擇-----");
                DropDownList4.Items.Add("11吋~14吋(含)");
                DropDownList4.Items.Add("15吋(含)以上");

                DropDownList5.Items.Clear();
                DropDownList5.Items.Add("----請選擇-----");
                DropDownList5.Items.Add("ASUS");
                DropDownList5.Items.Add("ACER");
                DropDownList5.Items.Add("HP");
                DropDownList5.Items.Add("Lenovo");



                click++;

            }

        }
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {//價格

            SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");

            SqlCommand cmd = null;
            SqlCommand cmd2 = null;
            conn.Open();
            if (DropDownList3.Text == "電競筆電")
            {
                //螢幕尺寸
                //DropDownList4.Items.Clear();
                //DropDownList4.Items.Add("----請選擇-----");
                //DropDownList4.Items.Add("15~16吋");
                //DropDownList4.Items.Add("16吋以上");


                if (DropDownList2.Text == "20000元~40000元")
                {
                    //Label4.Visible = true;
                    string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                      "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址 FROM GAME WHERE G_Price > 20000 AND G_Price<40000";
                    cmd = new SqlCommand(sSql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    dr.Dispose();
                    cmd.Dispose();

                }
                else if (DropDownList2.Text == "40000元~50000元")
                {
                    string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                     "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址 FROM GAME WHERE G_Price > 40000 AND G_Price<50000";
                    cmd = new SqlCommand(sSql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    dr.Dispose();
                    cmd.Dispose();

                }
                else
                {
                    string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                     "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                     " FROM GAME WHERE G_Price>50000";
                    cmd = new SqlCommand(sSql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;

                    GridView1.DataBind();
                    dr.Dispose();
                    cmd.Dispose();
                }

            }
            else if (DropDownList3.Text == "文書筆電")
            {

                if (DropDownList2.Text == "10000元以下")
                {
                    string sSql = "select O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM,O_HD as 硬碟大小," +
                    "O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址 from OFFICE where O_Price<10000";
                    cmd = new SqlCommand(sSql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();

                    dr.Dispose();
                    cmd.Dispose();

                }
                else if (DropDownList2.Text == "10000元~20000元")
                {
                    //Label4.Visible = false;
                    string sSql = "select O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM,O_HD as 硬碟大小," +
                    "O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址 from OFFICE WHERE O_Price >10000 AND O_Price < 20000";
                    cmd = new SqlCommand(sSql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    dr.Dispose();
                    cmd.Dispose();
                }
                else if (DropDownList2.Text == "20000元以上")
                {
                    string sSql = "select O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM,O_HD as 硬碟大小," +
                    "O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址 from OFFICE where O_Price>20000";
                    cmd = new SqlCommand(sSql, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    dr.Dispose();
                    cmd.Dispose();
                }
            }

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {//螢幕

            SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");

            SqlCommand cmd = null;
            
            conn.Open();
            if (DropDownList3.Text == "電競筆電")

            {
                if (DropDownList2.Text == "20000元~40000元")
                {                    
                    if (DropDownList4.Text == "15~16吋")
                    {

                        string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                             "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                             " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                    else if (DropDownList4.Text == "16吋以上")
                    {
                        string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                            "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                            " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }

                }
                else if (DropDownList2.Text == "40000元~50000元")
                {
                    if (DropDownList4.Text == "15~16吋")
                    {

                        string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                             "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                             " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                    else if (DropDownList4.Text == "16吋以上")
                    {
                        string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                            "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                            " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                }
                else if (DropDownList2.Text == "50000元以上")
                {
                    if (DropDownList4.Text == "15~16吋")
                    {

                        string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                             "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                             " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                    else if (DropDownList4.Text == "16吋以上")
                    {
                        string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                            "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                            " FROM GAME WHERE G_Size like '%17.3%' and  G_Price>50000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                }
            }
            else if (DropDownList3.Text == "文書筆電")

            {
                if (DropDownList2.Text == "10000元以下")
                {
                    if (DropDownList4.Text == "11吋~14吋(含)")
                    {                       
                        string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price<10000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                    else if (DropDownList4.Text == "15吋(含)以上")
                    {
                        string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price <10000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                }
                else if (DropDownList2.Text == "10000元~20000元")
                {

                    if (DropDownList4.Text == "11吋~14吋(含)")
                    {
                        string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%' ) and " +
                            "O_Price<20000 and O_Price>10000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                    else if (DropDownList4.Text == "15吋(含)以上")
                    {
                        string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price<20000 and O_Price>10000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                }
                if (DropDownList2.Text == "20000元以上")
                {
                    if (DropDownList4.Text == "11吋~14吋(含)")
                    {
                        string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') " +
                            "and O_Price>20000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                    else if (DropDownList4.Text == "15吋(含)以上")
                    {
                        string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price>20000";
                        cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                    }
                }
            }

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 品牌
            SqlConnection conn = new SqlConnection("Data Source=163.14.73.8;Initial Catalog=DB15;Persist Security Info=True;User ID=DB15;Password=DB15");

            SqlCommand cmd = null;          
            conn.Open();
            if (DropDownList3.Text == "電競筆電")

            {
                if (DropDownList2.Text == "20000元~40000元")
                {            
                    if (DropDownList4.Text == "15~16吋")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "DELL")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%DELL%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "MSI")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%MSI%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "GIGABYTE")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000 and" +
                                " G_Model like '%GIGABYTE%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                               "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                               " FROM GAME WHERE G_Size like '%15.6%' and G_Price<40000 and G_Price>20000 and" +
                               " G_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                    else if (DropDownList4.Text == "16吋以上")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {

                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "DELL")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%DELL%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "MSI")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000 and" +
                                 " G_Model like '%MSI%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "GIGABYTE")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000 and" +
                                " G_Model like '%GIGABYTE%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                               "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                               " FROM GAME WHERE G_Size like '%17.3%' and G_Price<40000 and G_Price>20000 and" +
                               " G_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }

                    }

                }
                else if (DropDownList2.Text == "40000元~50000元")
                {
                    if (DropDownList4.Text == "15~16吋")
                    {

                        if (DropDownList5.Text == "ASUS")
                        {

                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "DELL")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%DELL%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "MSI")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%MSI%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "GIGABYTE")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000 and" +
                                " G_Model like '%GIGABYTE%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                               "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                               " FROM GAME WHERE G_Size like '%15.6%' and G_Price>40000 and G_Price<50000 and" +
                               " G_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                    else if (DropDownList4.Text == "16吋以上")
                    {

                        if (DropDownList5.Text == "ASUS")
                        {

                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "DELL")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%DELL%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "MSI")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000 and" +
                                 " G_Model like '%MSI%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "GIGABYTE")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000 and" +
                                " G_Model like '%GIGABYTE%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                               "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                               " FROM GAME WHERE G_Size like '%17.3%' and G_Price>40000 and G_Price<50000 and" +
                               " G_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                }
                else if (DropDownList2.Text == "50000元以上")
                {
                    if (DropDownList4.Text == "15~16吋")
                    {

                        if (DropDownList5.Text == "ASUS")
                        {

                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000 and" +
                                 " G_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000 and" +
                                 " G_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "DELL")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000 and" +
                                 " G_Model like '%DELL%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "MSI")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000 and" +
                                 " G_Model like '%MSI%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "GIGABYTE")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000 and" +
                                " G_Model like '%GIGABYTE%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                               "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                               " FROM GAME WHERE G_Size like '%15.6%' and G_Price>50000 and" +
                               " G_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                    else if (DropDownList4.Text == "16吋以上")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {

                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>50000 and" +
                                 " G_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>50000 and" +
                                 " G_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "DELL")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>50000 and" +
                                 " G_Model like '%DELL%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "MSI")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                 "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                 " FROM GAME WHERE G_Size like '%17.3%' and G_Price>50000 and" +
                                 " G_Model like '%MSI%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "GIGABYTE")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                                "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                                " FROM GAME WHERE G_Size like '%17.3%' and G_Price>50000 and" +
                                " G_Model like '%GIGABYTE%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  G_Model as 筆電型號 ,G_Processor as 處理器,G_RAM as RAM," +
                               "G_HD as 硬碟大小,G_VGA as 顯示卡規格,G_Size as 螢幕大小,G_Price as 價格,G_URL as 購買網址" +
                               " FROM GAME WHERE G_Size like '%17.3%' and G_Price>50000 and" +
                               " G_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                }
            }
        
            else if (DropDownList3.Text == "文書筆電")

            {
                if (DropDownList2.Text == "10000元以下")
                {
                    if (DropDownList4.Text == "11吋~14吋(含)")
                    {

                        if (DropDownList5.Text == "ASUS")
                        {
                             string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price<10000" +
                            " and O_Model like '%ASUS%' ";


                            cmd = new SqlCommand(sSql, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                        dr.Dispose();
                        cmd.Dispose();
                        }
                        else if(DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price<10000" +
                            " and O_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if(DropDownList5.Text == "HP")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price<10000" +
                            " and O_Model like '%HP%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if(DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price<10000" +
                            " and O_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                       
                    }
                    else if (DropDownList4.Text == "15吋(含)以上")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE  O_Size like '%15.6%' and O_Price<10000" +
                           " and O_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE O_Size like '%15.6%'and O_Price<10000" +
                            " and O_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "HP")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE O_Size like '%15.6%'and O_Price<10000" +
                            " and O_Model like '%HP%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price<10000" +
                            " and O_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                }
                else if (DropDownList2.Text == "10000元~20000元")
                {

                    if (DropDownList4.Text == "11吋~14吋(含)")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                                "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                                " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and " +
                                " O_Price<20000 and O_Price>10000 and O_Model like '%ASUS%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if(DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                                "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                                " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and " +
                                "O_Price<20000 and O_Price>10000 and O_Model like '%ACER%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if(DropDownList5.Text == "HP")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                                "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                                " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and " +
                                "O_Price<20000 and O_Price>10000 and O_Model like '%HP%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if(DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                                "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                                " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and " +
                                "O_Price<20000 and O_Price>10000 and O_Model like '%Lenovo%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                    else if (DropDownList4.Text == "15吋(含)以上")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and (O_Price<20000 and O_Price>10000) and O_Model like '%ASUS%' ";
                            //"AND 0_Model like '%ASUS%'";
                            //string sSql = tes;
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price<20000 and O_Price>10000 and O_Model like '%ACER%'";
                          // " AND 0_Model like '%ACER%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "HP")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price<20000 and O_Price>10000 and O_Model like '%HP%' ";
                           //"AND 0_Model like '%HP%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price<20000 and O_Price>10000 and O_Model like '%Lenovo%'";
                          // "AND 0_Model like '%Lenovo%'";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                }
                if (DropDownList2.Text == "20000元以上")
                {
                    if (DropDownList4.Text == "11吋~14吋(含)")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price>20000" +
                           " and O_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price>20000" +
                            " and O_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "HP")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price>20000" +
                            " and O_Model like '%HP%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE (O_Size like '%11.6%' OR O_Size like '%14%' or O_Size like '%13.3%') and O_Price>20000" +
                            " and O_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                    else if (DropDownList4.Text == "15吋(含)以上")
                    {
                        if (DropDownList5.Text == "ASUS")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                           "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                           " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price>20000" +
                           " and O_Model like '%ASUS%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "ACER")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE O_Size like '%15.6%'and O_Price>20000" +
                            " and O_Model like '%ACER%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "HP")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE O_Size like '%15.6%'and O_Price>20000" +
                            " and O_Model like '%HP%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                        else if (DropDownList5.Text == "Lenovo")
                        {
                            string sSql = "SELECT  O_Model as 筆電型號 ,O_Processor as 處理器,O_RAM as RAM," +
                            "O_HD as 硬碟大小,O_VGA as 顯示卡規格,O_Size as 螢幕大小,O_Price as 價格,O_URL as 購買網址" +
                            " FROM OFFICE WHERE O_Size like '%15.6%' and O_Price>20000" +
                            " and O_Model like '%Lenovo%' ";
                            cmd = new SqlCommand(sSql, conn);
                            SqlDataReader dr = cmd.ExecuteReader();
                            GridView1.DataSource = dr;
                            GridView1.DataBind();

                            dr.Dispose();
                            cmd.Dispose();
                        }
                    }
                }
            }

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
                Response.Redirect("首頁.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Robot.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Image3.Visible = true;
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
