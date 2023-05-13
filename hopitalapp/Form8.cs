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
    public partial class vupro : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-CC82OPD\\SQLEXPRESS;Database=ho;Connection Timeout=30;Integrated Security=true");

        public vupro()
        {

            InitializeComponent();
            SqlDataAdapter ad = new SqlDataAdapter("select * from process", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void vupro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from process where docname like '%"+ textBox1.Text+ "%'", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
