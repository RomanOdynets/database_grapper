using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MSSQL
{
    public partial class Form1 : Form
    {
        SqlConnection conn = DBUtils.GetDB();
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM users WHERE id = " + textBox1.Text;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sd.Fill(ds);

            foreach(DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    // 1 - номер столбика что мне нужен, начало с 0
                    label1.Text = dr.ItemArray[1].ToString();
                }
            }
        }
    }
}
