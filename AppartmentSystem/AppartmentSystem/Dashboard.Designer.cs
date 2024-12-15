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
            this.lbl_maintenanceRequestOutput = new System.Windows.Forms.Label();
            this.lbl_InactiveRoomOutput = new System.Windows.Forms.Label();
            this.lbl_ActiveRoomOutput = new System.Windows.Forms.Label();
            this.lbl_MaintenanceRequest = new System.Windows.Forms.Label();
            this.lbl_InactiveRoom = new System.Windows.Forms.Label();
            this.lbl_TotalActiveRoom = new System.Windows.Forms.Label();
            this.panel_actRoom = new System.Windows.Forms.Panel();
            this.panel_inactRoom = new System.Windows.Forms.Panel();
            this.panel_maintenanceRequest = new System.Windows.Forms.Panel();
            this.panel_headDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_tenantProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_actRoom.SuspendLayout();
            this.panel_inactRoom.SuspendLayout();
            this.panel_maintenanceRequest.SuspendLayout();
            this.panel_headDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(384, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(211, 50);
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
            this.btn_manageRoom.Location = new System.Drawing.Point(21, 110);
            this.btn_manageRoom.Name = "btn_manageRoom";
            this.btn_manageRoom.Size = new System.Drawing.Size(160, 80);
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
            this.btn_manageLeases.Location = new System.Drawing.Point(21, 209);
            this.btn_manageLeases.Name = "btn_manageLeases";
            this.btn_manageLeases.Size = new System.Drawing.Size(160, 80);
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
            this.btn_financialData.Location = new System.Drawing.Point(21, 309);
            this.btn_financialData.Name = "btn_financialData";
            this.btn_financialData.Size = new System.Drawing.Size(160, 80);
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
            this.btn_AssignMaintenance.Location = new System.Drawing.Point(21, 411);
            this.btn_AssignMaintenance.Name = "btn_AssignMaintenance";
            this.btn_AssignMaintenance.Size = new System.Drawing.Size(160, 80);
            this.btn_AssignMaintenance.TabIndex = 4;
            this.btn_AssignMaintenance.Text = "Track And Assign Maintenance";
            this.btn_AssignMaintenance.UseVisualStyleBackColor = false;
            this.btn_AssignMaintenance.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_maintenanceRequestOutput
            // 
            this.lbl_maintenanceRequestOutput.AutoSize = true;
            this.lbl_maintenanceRequestOutput.Location = new System.Drawing.Point(20, 30);
            this.lbl_maintenanceRequestOutput.Name = "lbl_maintenanceRequestOutput";
            this.lbl_maintenanceRequestOutput.Size = new System.Drawing.Size(73, 13);
            this.lbl_maintenanceRequestOutput.TabIndex = 5;
            this.lbl_maintenanceRequestOutput.Text = "maint_request";
            this.lbl_maintenanceRequestOutput.Visible = false;
            // 
            // lbl_InactiveRoomOutput
            // 
            this.lbl_InactiveRoomOutput.AutoSize = true;
            this.lbl_InactiveRoomOutput.Location = new System.Drawing.Point(20, 23);
            this.lbl_InactiveRoomOutput.Name = "lbl_InactiveRoomOutput";
            this.lbl_InactiveRoomOutput.Size = new System.Drawing.Size(62, 13);
            this.lbl_InactiveRoomOutput.TabIndex = 4;
            this.lbl_InactiveRoomOutput.Text = "Inact Room";
            this.lbl_InactiveRoomOutput.Visible = false;
            // 
            // lbl_ActiveRoomOutput
            // 
            this.lbl_ActiveRoomOutput.AutoSize = true;
            this.lbl_ActiveRoomOutput.Location = new System.Drawing.Point(20, 30);
            this.lbl_ActiveRoomOutput.Name = "lbl_ActiveRoomOutput";
            this.lbl_ActiveRoomOutput.Size = new System.Drawing.Size(50, 13);
            this.lbl_ActiveRoomOutput.TabIndex = 3;
            this.lbl_ActiveRoomOutput.Text = "actRoom";
            this.lbl_ActiveRoomOutput.Visible = false;
            this.lbl_ActiveRoomOutput.Click += new System.EventHandler(this.lbl_ActiveRoomOutput_Click);
            // 
            // lbl_MaintenanceRequest
            // 
            this.lbl_MaintenanceRequest.AutoSize = true;
            this.lbl_MaintenanceRequest.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaintenanceRequest.Location = new System.Drawing.Point(-10, 67);
            this.lbl_MaintenanceRequest.Name = "lbl_MaintenanceRequest";
            this.lbl_MaintenanceRequest.Size = new System.Drawing.Size(293, 37);
            this.lbl_MaintenanceRequest.TabIndex = 2;
            this.lbl_MaintenanceRequest.Text = "Maintenance Request";
            // 
            // lbl_InactiveRoom
            // 
            this.lbl_InactiveRoom.AutoSize = true;
            this.lbl_InactiveRoom.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InactiveRoom.Location = new System.Drawing.Point(-6, 67);
            this.lbl_InactiveRoom.Name = "lbl_InactiveRoom";
            this.lbl_InactiveRoom.Size = new System.Drawing.Size(202, 37);
            this.lbl_InactiveRoom.TabIndex = 1;
            this.lbl_InactiveRoom.Text = "Inactive Room";
            // 
            // lbl_TotalActiveRoom
            // 
            this.lbl_TotalActiveRoom.AutoSize = true;
            this.lbl_TotalActiveRoom.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalActiveRoom.Location = new System.Drawing.Point(-6, 63);
            this.lbl_TotalActiveRoom.Name = "lbl_TotalActiveRoom";
            this.lbl_TotalActiveRoom.Size = new System.Drawing.Size(181, 37);
            this.lbl_TotalActiveRoom.TabIndex = 0;
            this.lbl_TotalActiveRoom.Text = "Active Room";
            this.lbl_TotalActiveRoom.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_actRoom
            // 
            this.panel_actRoom.BackColor = System.Drawing.Color.Transparent;
            this.panel_actRoom.Controls.Add(this.lbl_TotalActiveRoom);
            this.panel_actRoom.Controls.Add(this.lbl_ActiveRoomOutput);
            this.panel_actRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_actRoom.Location = new System.Drawing.Point(216, 90);
            this.panel_actRoom.Name = "panel_actRoom";
            this.panel_actRoom.Size = new System.Drawing.Size(261, 100);
            this.panel_actRoom.TabIndex = 6;
            this.panel_actRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_inactRoom
            // 
            this.panel_inactRoom.BackColor = System.Drawing.Color.Transparent;
            this.panel_inactRoom.Controls.Add(this.lbl_InactiveRoom);
            this.panel_inactRoom.Controls.Add(this.lbl_InactiveRoomOutput);
            this.panel_inactRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_inactRoom.Location = new System.Drawing.Point(216, 222);
            this.panel_inactRoom.Name = "panel_inactRoom";
            this.panel_inactRoom.Size = new System.Drawing.Size(261, 100);
            this.panel_inactRoom.TabIndex = 7;
            // 
            // panel_maintenanceRequest
            // 
            this.panel_maintenanceRequest.BackColor = System.Drawing.Color.Transparent;
            this.panel_maintenanceRequest.Controls.Add(this.lbl_MaintenanceRequest);
            this.panel_maintenanceRequest.Controls.Add(this.lbl_maintenanceRequestOutput);
            this.panel_maintenanceRequest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_maintenanceRequest.Location = new System.Drawing.Point(217, 361);
            this.panel_maintenanceRequest.Name = "panel_maintenanceRequest";
            this.panel_maintenanceRequest.Size = new System.Drawing.Size(286, 100);
            this.panel_maintenanceRequest.TabIndex = 8;
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
            this.panel_headDashboard.Name = "panel_headDashboard";
            this.panel_headDashboard.Size = new System.Drawing.Size(1209, 71);
            this.panel_headDashboard.TabIndex = 9;
            this.panel_headDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_headDashboard_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 62);
            this.label1.TabIndex = 6;
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.BackColor = System.Drawing.Color.Transparent;
            this.lbl_admin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_admin.Location = new System.Drawing.Point(78, 13);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(120, 45);
            this.lbl_admin.TabIndex = 5;
            this.lbl_admin.Text = "Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(502, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(484, 236);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 685);
            this.panel1.TabIndex = 12;
            // 
            // btn_tenantProfile
            // 
            this.btn_tenantProfile.BackColor = System.Drawing.Color.LightCyan;
            this.btn_tenantProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tenantProfile.Location = new System.Drawing.Point(21, 525);
            this.btn_tenantProfile.Name = "btn_tenantProfile";
            this.btn_tenantProfile.Size = new System.Drawing.Size(160, 80);
            this.btn_tenantProfile.TabIndex = 5;
            this.btn_tenantProfile.Text = "Tenant Profiling";
            this.btn_tenantProfile.UseVisualStyleBackColor = false;
            this.btn_tenantProfile.Click += new System.EventHandler(this.btn_tenantProfile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(519, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 278);
            this.label2.TabIndex = 13;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 685);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_headDashboard);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_maintenanceRequest);
            this.Controls.Add(this.panel_inactRoom);
            this.Controls.Add(this.panel_actRoom);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.panel_actRoom.ResumeLayout(false);
            this.panel_actRoom.PerformLayout();
            this.panel_inactRoom.ResumeLayout(false);
            this.panel_inactRoom.PerformLayout();
            this.panel_maintenanceRequest.ResumeLayout(false);
            this.panel_maintenanceRequest.PerformLayout();
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
        private System.Windows.Forms.Label lbl_TotalActiveRoom;
        private System.Windows.Forms.Label lbl_InactiveRoom;
        private System.Windows.Forms.Label lbl_maintenanceRequestOutput;
        private System.Windows.Forms.Label lbl_InactiveRoomOutput;
        private System.Windows.Forms.Label lbl_ActiveRoomOutput;
        private System.Windows.Forms.Label lbl_MaintenanceRequest;
        private System.Windows.Forms.Panel panel_actRoom;
        private System.Windows.Forms.Panel panel_inactRoom;
        private System.Windows.Forms.Panel panel_maintenanceRequest;
        private System.Windows.Forms.Panel panel_headDashboard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tenantProfile;
    }
}