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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hopitalapp
{
    public partial class process : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-CC82OPD\\SQLEXPRESS;Database=ho;Connection Timeout=30;Integrated Security=true");

        public process()
        {
            InitializeComponent();
            SqlDataAdapter a1 = new SqlDataAdapter("select * from patient", conn);
            DataTable d1 = new DataTable();
            a1.Fill(d1);
            comboBox1.DataSource = d1;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            SqlDataAdapter a2 = new SqlDataAdapter("select * from doctor", conn);
            DataTable d2 = new DataTable();
            a2.Fill(d2);
            comboBox2.DataSource = d2;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";




        }

        private void process_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into process values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" +Convert.ToInt32(comboBox1.SelectedValue )+ "','" +Convert.ToInt32(comboBox2.SelectedValue )+ "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox1.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("add process succeful");
            comboBox1.Text = "";
            comboBox2.Text = "";
            
            textBox1.Text = "";
        }
    }
}
