namespace AppartmentSystem
{
    partial class Frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_manageRoom = new System.Windows.Forms.Button();
            this.btn_manageLeases = new System.Windows.Forms.Button();
            this.btn_financialData = new System.Windows.Forms.Button();
            this.btn_AssignMaintenance = new System.Windows.Forms.Button();
            this.panel_headDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tenantProfile = new System.Windows.Forms.Button();
            this.lbl_motto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_headDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(711, 16);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(267, 62);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Dashboard";
            // 
            // btn_manageRoom
            // 
            this.btn_manageRoom.BackColor = System.Drawing.Color.LightCyan;
            this.btn_manageRoom.FlatAppearance.BorderSize = 0;
            this.btn_manageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_manageRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageRoom.Location = new System.Drawing.Point(28, 135);
            this.btn_manageRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_manageRoom.Name = "btn_manageRoom";
            this.btn_manageRoom.Size = new System.Drawing.Size(213, 98);
            this.btn_manageRoom.TabIndex = 1;
            this.btn_manageRoom.Text = "  Manage Room";
            this.btn_manageRoom.UseVisualStyleBackColor = false;
            this.btn_manageRoom.Click += new System.EventHandler(this.btn_manageRoom_Click);
            // 
            // btn_manageLeases
            // 
            this.btn_manageLeases.BackColor = System.Drawing.Color.LightCyan;
            this.btn_manageLeases.FlatAppearance.BorderSize = 0;
            this.btn_manageLeases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageLeases.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageLeases.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_manageLeases.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageLeases.Location = new System.Drawing.Point(28, 257);
            this.btn_manageLeases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_manageLeases.Name = "btn_manageLeases";
            this.btn_manageLeases.Size = new System.Drawing.Size(213, 98);
            this.btn_manageLeases.TabIndex = 2;
            this.btn_manageLeases.Text = "   Manage Leases";
            this.btn_manageLeases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageLeases.UseVisualStyleBackColor = false;
            this.btn_manageLeases.Click += new System.EventHandler(this.btn_manageLeases_Click);
            // 
            // btn_financialData
            // 
            this.btn_financialData.BackColor = System.Drawing.Color.LightCyan;
            this.btn_financialData.FlatAppearance.BorderSize = 0;
            this.btn_financialData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financialData.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financialData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_financialData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_financialData.Location = new System.Drawing.Point(28, 380);
            this.btn_financialData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_financialData.Name = "btn_financialData";
            this.btn_financialData.Size = new System.Drawing.Size(213, 98);
            this.btn_financialData.TabIndex = 3;
            this.btn_financialData.Text = "  Financial Data";
            this.btn_financialData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financialData.UseVisualStyleBackColor = false;
            this.btn_financialData.Click += new System.EventHandler(this.btn_financialData_Click);
            // 
            // btn_AssignMaintenance
            // 
            this.btn_AssignMaintenance.BackColor = System.Drawing.Color.LightCyan;
            this.btn_AssignMaintenance.FlatAppearance.BorderSize = 0;
            this.btn_AssignMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssignMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssignMaintenance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AssignMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AssignMaintenance.Location = new System.Drawing.Point(28, 506);
            this.btn_AssignMaintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AssignMaintenance.Name = "btn_AssignMaintenance";
            this.btn_AssignMaintenance.Size = new System.Drawing.Size(213, 98);
            this.btn_AssignMaintenance.TabIndex = 4;
            this.btn_AssignMaintenance.Text = "Track And Assign Maintenance";
            this.btn_AssignMaintenance.UseVisualStyleBackColor = false;
            this.btn_AssignMaintenance.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_headDashboard
            // 
            this.panel_headDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_headDashboard.BackColor = System.Drawing.Color.CadetBlue;
            this.panel_headDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_headDashboard.BackgroundImage")));
            this.panel_headDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_headDashboard.Controls.Add(this.label1);
            this.panel_headDashboard.Controls.Add(this.lbl_admin);
            this.panel_headDashboard.Controls.Add(this.lbl_header);
            this.panel_headDashboard.Location = new System.Drawing.Point(0, 0);
            this.panel_headDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_headDashboard.Name = "panel_headDashboard";
            this.panel_headDashboard.Size = new System.Drawing.Size(1612, 87);
            this.panel_headDashboard.TabIndex = 9;
            this.panel_headDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_headDashboard_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 76);
            this.label1.TabIndex = 6;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_admin.Location = new System.Drawing.Point(104, 16);
            this.lbl_admin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(148, 54);
            this.lbl_admin.TabIndex = 5;
            this.lbl_admin.Text = "Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 290);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_tenantProfile);
            this.panel1.Controls.Add(this.btn_manageRoom);
            this.panel1.Controls.Add(this.btn_AssignMaintenance);
            this.panel1.Controls.Add(this.btn_manageLeases);
            this.panel1.Controls.Add(this.btn_financialData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 843);
            this.panel1.TabIndex = 12;
            // 
            // btn_tenantProfile
            // 
            this.btn_tenantProfile.BackColor = System.Drawing.Color.LightCyan;
            this.btn_tenantProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tenantProfile.Location = new System.Drawing.Point(28, 646);
            this.btn_tenantProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tenantProfile.Name = "btn_tenantProfile";
            this.btn_tenantProfile.Size = new System.Drawing.Size(213, 98);
            this.btn_tenantProfile.TabIndex = 5;
            this.btn_tenantProfile.Text = "Tenant Profiling";
            this.btn_tenantProfile.UseVisualStyleBackColor = false;
            this.btn_tenantProfile.Click += new System.EventHandler(this.btn_tenantProfile_Click);
            // 
            // lbl_motto
            // 
            this.lbl_motto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_motto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_motto.Font = new System.Drawing.Font("Calisto MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lbl_motto.Location = new System.Drawing.Point(674, 614);
            this.lbl_motto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_motto.Name = "lbl_motto";
            this.lbl_motto.Size = new System.Drawing.Size(361, 170);
            this.lbl_motto.TabIndex = 14;
            this.lbl_motto.Text = "You Live, We Provide";
            this.lbl_motto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(569, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(567, 220);
            this.label3.TabIndex = 15;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 843);
            this.Controls.Add(this.lbl_motto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_headDashboard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.panel_headDashboard.ResumeLayout(false);
            this.panel_headDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_manageRoom;
        private System.Windows.Forms.Button btn_manageLeases;
        private System.Windows.Forms.Button btn_financialData;
        private System.Windows.Forms.Button btn_AssignMaintenance;
        private System.Windows.Forms.Panel panel_headDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tenantProfile;
        private System.Windows.Forms.Label lbl_motto;
        private System.Windows.Forms.Label label3;
    }
}