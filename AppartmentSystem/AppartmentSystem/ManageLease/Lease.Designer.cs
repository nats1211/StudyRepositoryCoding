namespace AppartmentSystem
{
    partial class Lease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lease));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_updateLease = new System.Windows.Forms.Button();
            this.btn_historyLease = new System.Windows.Forms.Button();
            this.btn_mlBack = new System.Windows.Forms.Button();
            this.txtRoomBill = new System.Windows.Forms.TextBox();
            this.lbl_maintenanceCost = new System.Windows.Forms.Label();
            this.lbl_tenantName = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_leaseStart = new System.Windows.Forms.Label();
            this.lbl_roomNumberleaseOutput = new System.Windows.Forms.Label();
            this.panel_sample = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_infoml = new System.Windows.Forms.Label();
            this.btn_addLease = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_sample.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(951, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_updateLease
            // 
            this.btn_updateLease.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateLease.Image")));
            this.btn_updateLease.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateLease.Location = new System.Drawing.Point(126, 262);
            this.btn_updateLease.Name = "btn_updateLease";
            this.btn_updateLease.Size = new System.Drawing.Size(8, 17);
            this.btn_updateLease.TabIndex = 15;
            this.btn_updateLease.Text = "Update";
            this.btn_updateLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateLease.UseVisualStyleBackColor = true;
            this.btn_updateLease.Visible = false;
            this.btn_updateLease.Click += new System.EventHandler(this.btn_updateLease_Click);
            // 
            // btn_historyLease
            // 
            this.btn_historyLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_historyLease.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_historyLease.FlatAppearance.BorderSize = 0;
            this.btn_historyLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_historyLease.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_historyLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_historyLease.Image")));
            this.btn_historyLease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_historyLease.Location = new System.Drawing.Point(873, 98);
            this.btn_historyLease.Name = "btn_historyLease";
            this.btn_historyLease.Size = new System.Drawing.Size(105, 46);
            this.btn_historyLease.TabIndex = 19;
            this.btn_historyLease.Text = " History";
            this.btn_historyLease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_historyLease.UseVisualStyleBackColor = false;
            this.btn_historyLease.Click += new System.EventHandler(this.btn_archiveLease_Click);
            // 
            // btn_mlBack
            // 
            this.btn_mlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mlBack.BackgroundImage")));
            this.btn_mlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mlBack.Location = new System.Drawing.Point(938, 15);
            this.btn_mlBack.Name = "btn_mlBack";
            this.btn_mlBack.Size = new System.Drawing.Size(40, 35);
            this.btn_mlBack.TabIndex = 22;
            this.btn_mlBack.UseVisualStyleBackColor = true;
            this.btn_mlBack.Click += new System.EventHandler(this.btn_mlBack_Click);
            // 
            // txtRoomBill
            // 
            this.txtRoomBill.Location = new System.Drawing.Point(301, 66);
            this.txtRoomBill.Name = "txtRoomBill";
            this.txtRoomBill.Size = new System.Drawing.Size(126, 20);
            this.txtRoomBill.TabIndex = 12;
            // 
            // lbl_maintenanceCost
            // 
            this.lbl_maintenanceCost.AutoSize = true;
            this.lbl_maintenanceCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maintenanceCost.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maintenanceCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_maintenanceCost.Location = new System.Drawing.Point(200, 69);
            this.lbl_maintenanceCost.Name = "lbl_maintenanceCost";
            this.lbl_maintenanceCost.Size = new System.Drawing.Size(100, 17);
            this.lbl_maintenanceCost.TabIndex = 10;
            this.lbl_maintenanceCost.Text = "Maintenance Cost:\r\n";
            // 
            // lbl_tenantName
            // 
            this.lbl_tenantName.AutoSize = true;
            this.lbl_tenantName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenantName.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenantName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tenantName.Location = new System.Drawing.Point(3, 69);
            this.lbl_tenantName.Name = "lbl_tenantName";
            this.lbl_tenantName.Size = new System.Drawing.Size(74, 17);
            this.lbl_tenantName.TabIndex = 4;
            this.lbl_tenantName.Text = "Tenant Name:";
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(83, 66);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(100, 20);
            this.txtTenantName.TabIndex = 3;
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_roomNo.Location = new System.Drawing.Point(3, 22);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(79, 17);
            this.lbl_roomNo.TabIndex = 1;
            this.lbl_roomNo.Text = "Room Number:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 19);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lbl_leaseStart
            // 
            this.lbl_leaseStart.AutoSize = true;
            this.lbl_leaseStart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leaseStart.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaseStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_leaseStart.Location = new System.Drawing.Point(200, 20);
            this.lbl_leaseStart.Name = "lbl_leaseStart";
            this.lbl_leaseStart.Size = new System.Drawing.Size(67, 17);
            this.lbl_leaseStart.TabIndex = 20;
            this.lbl_leaseStart.Text = "Lease Start:";
            // 
            // lbl_roomNumberleaseOutput
            // 
            this.lbl_roomNumberleaseOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_roomNumberleaseOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_roomNumberleaseOutput.Location = new System.Drawing.Point(69, 14);
            this.lbl_roomNumberleaseOutput.Name = "lbl_roomNumberleaseOutput";
            this.lbl_roomNumberleaseOutput.Size = new System.Drawing.Size(144, 55);
            this.lbl_roomNumberleaseOutput.TabIndex = 18;
            // 
            // panel_sample
            // 
            this.panel_sample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_sample.Controls.Add(this.lbl_roomNumberleaseOutput);
            this.panel_sample.Controls.Add(this.lbl_leaseStart);
            this.panel_sample.Controls.Add(this.dateTimePicker1);
            this.panel_sample.Controls.Add(this.lbl_roomNo);
            this.panel_sample.Controls.Add(this.txtTenantName);
            this.panel_sample.Controls.Add(this.lbl_tenantName);
            this.panel_sample.Controls.Add(this.lbl_maintenanceCost);
            this.panel_sample.Controls.Add(this.txtRoomBill);
            this.panel_sample.Location = new System.Drawing.Point(2, 713);
            this.panel_sample.Name = "panel_sample";
            this.panel_sample.Size = new System.Drawing.Size(16, 17);
            this.panel_sample.TabIndex = 23;
            this.panel_sample.Visible = false;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(21, 15);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(231, 45);
            this.lbl_Header.TabIndex = 24;
            this.lbl_Header.Text = "Manage Lease";
            // 
            // lbl_infoml
            // 
            this.lbl_infoml.AutoSize = true;
            this.lbl_infoml.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infoml.Location = new System.Drawing.Point(26, 60);
            this.lbl_infoml.Name = "lbl_infoml";
            this.lbl_infoml.Size = new System.Drawing.Size(239, 15);
            this.lbl_infoml.TabIndex = 25;
            this.lbl_infoml.Text = "It checks, renews, and view previous tenants";
            // 
            // btn_addLease
            // 
            this.btn_addLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addLease.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addLease.FlatAppearance.BorderSize = 0;
            this.btn_addLease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addLease.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_addLease.Image")));
            this.btn_addLease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addLease.Location = new System.Drawing.Point(762, 98);
            this.btn_addLease.Name = "btn_addLease";
            this.btn_addLease.Size = new System.Drawing.Size(105, 45);
            this.btn_addLease.TabIndex = 26;
            this.btn_addLease.Text = "       Add";
            this.btn_addLease.UseVisualStyleBackColor = false;
            this.btn_addLease.Click += new System.EventHandler(this.btn_addLease_Click_1);
            // 
            // ManageLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_addLease);
            this.Controls.Add(this.lbl_infoml);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.btn_mlBack);
            this.Controls.Add(this.btn_historyLease);
            this.Controls.Add(this.btn_updateLease);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_sample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageLease";
            this.Text = "ManageLease";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageLease_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ManageLease_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_sample.ResumeLayout(false);
            this.panel_sample.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_updateLease;
        private System.Windows.Forms.Button btn_historyLease;
        private System.Windows.Forms.Button btn_mlBack;
        private System.Windows.Forms.TextBox txtRoomBill;
        private System.Windows.Forms.Label lbl_maintenanceCost;
        private System.Windows.Forms.Label lbl_tenantName;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_leaseStart;
        private System.Windows.Forms.Label lbl_roomNumberleaseOutput;
        private System.Windows.Forms.Panel panel_sample;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_infoml;
        private System.Windows.Forms.Button btn_addLease;
    }
}