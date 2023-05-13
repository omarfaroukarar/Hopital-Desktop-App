using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace hopitalapp
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-CC82OPD\\SQLEXPRESS;Database=ho;Connection Timeout=30;Integrated Security=true");
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from omar where username='"+textBox1.Text+"'";
            

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count>0)
            {
                main f = new main();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("eror");

            }



            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
