using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace hopitalapp
{
    public partial class adddoctor : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-CC82OPD\\SQLEXPRESS;Database=ho;Connection Timeout=30;Integrated Security=true");

        public adddoctor()
        {
            InitializeComponent();
        }

        private void adddoctor_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into doctor values ('"+textBox1.Text+ "','"+textBox2.Text+ "','"+textBox3.Text+ "','"+textBox4.Text+"')",conn) ;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("add doctor succeful");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
