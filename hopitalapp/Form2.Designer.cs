namespace hopitalapp
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.processToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.managementDoctorToolStripMenuItem});
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.doctorsToolStripMenuItem.Text = "doctors";
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.addDoctorToolStripMenuItem.Text = "add doctor";
            this.addDoctorToolStripMenuItem.Click += new System.EventHandler(this.addDoctorToolStripMenuItem_Click);
            // 
            // managementDoctorToolStripMenuItem
            // 
            this.managementDoctorToolStripMenuItem.Name = "managementDoctorToolStripMenuItem";
            this.managementDoctorToolStripMenuItem.Size = new System.Drawing.Size(277, 34);
            this.managementDoctorToolStripMenuItem.Text = "management doctor";
            this.managementDoctorToolStripMenuItem.Click += new System.EventHandler(this.managementDoctorToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.patientToolStripMenuItem.Text = "patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProcessToolStripMenuItem,
            this.manageProcessToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.processToolStripMenuItem.Text = "process";
            // 
            // addProcessToolStripMenuItem
            // 
            this.addProcessToolStripMenuItem.Name = "addProcessToolStripMenuItem";
            this.addProcessToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addProcessToolStripMenuItem.Text = "add process";
            this.addProcessToolStripMenuItem.Click += new System.EventHandler(this.addProcessToolStripMenuItem_Click);
            // 
            // manageProcessToolStripMenuItem
            // 
            this.manageProcessToolStripMenuItem.Name = "manageProcessToolStripMenuItem";
            this.manageProcessToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.manageProcessToolStripMenuItem.Text = "manage process";
            this.manageProcessToolStripMenuItem.Click += new System.EventHandler(this.manageProcessToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}