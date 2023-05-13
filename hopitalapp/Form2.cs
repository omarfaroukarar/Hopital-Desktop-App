using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hopitalapp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void addDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adddoctor f = new adddoctor();
            f.Show();
            
        }

        private void managementDoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managdoctors f = new managdoctors();
            f.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patient f = new patient();
            f.Show();
        }

        private void addProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process f = new process();
            f.Show();
        }

        private void manageProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vupro f = new vupro();
            f.Show();
        }
    }
}
