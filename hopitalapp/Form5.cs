using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace hopitalapp
{
    public partial class editdoctor : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-CC82OPD\\SQLEXPRESS;Database=ho;Connection Timeout=30;Integrated Security=true");

        public editdoctor()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update doctor set name='"+textBox1.Text+ "',phone='"+ textBox2.Text + "',section='"+ textBox3.Text + "',address='"+ textBox4.Text + "'where id='"+Convert.ToInt32( textBox5.Text)+ "'",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("edit info succeful");
            
            
        }
    }
}
