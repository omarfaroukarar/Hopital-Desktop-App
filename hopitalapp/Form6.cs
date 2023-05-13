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
using DevExpress.XtraEditors;

namespace hopitalapp
{
    public partial class patient : Form
    {
        SqlConnection conn = new SqlConnection("server=DESKTOP-CC82OPD\\SQLEXPRESS;Database=ho;Connection Timeout=30;Integrated Security=true");

        public patient()
        {
            InitializeComponent();
            simpleButton2.Enabled = false;
            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into patient values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +Convert.ToInt32( textBox4.Text )+ "','" + textBox5.Text + "','" + textBox6.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("add patient succeful");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sur you want delete") == DialogResult.OK)

            {

            
            SqlCommand cmd = new SqlCommand("delete from patient where id='" + Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value) + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("delete succefuly");
            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox7.Visible = true;
            label7.Visible = true;
            simpleButton4.Enabled = false;
            simpleButton2.Enabled = true;

            textBox7.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update patient set name='" + textBox1.Text + "',phone='" + textBox2.Text + "',address='" + textBox3.Text + "',age='" + Convert.ToInt32(textBox4.Text) + "',state='" + textBox5.Text + "',section='" + textBox6.Text + "'where id='" + Convert.ToInt32(textBox7.Text) + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("edit info succeful");

            SqlDataAdapter ad = new SqlDataAdapter("select * from patient", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView2.DataSource = dt;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }
    }
}
