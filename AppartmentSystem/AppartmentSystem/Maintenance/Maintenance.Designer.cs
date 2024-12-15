namespace AppartmentSystem
{
    partial class Frm_Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Maintenance));
            this.dg_maintenance = new System.Windows.Forms.DataGridView();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.txt_issue = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_priority = new System.Windows.Forms.TextBox();
            this.btn_addMaintenance = new System.Windows.Forms.Button();
            this.btn_editMaintenance = new System.Windows.Forms.Button();
            this.btn_updateMaintenance = new System.Windows.Forms.Button();
            this.lbl_maintenanceRoomOutput = new System.Windows.Forms.Label();
            this.btn_maintenanceBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_maintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_maintenance
            // 
            this.dg_maintenance.AllowUserToAddRows = false;
            this.dg_maintenance.AllowUserToDeleteRows = false;
            this.dg_maintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_maintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_maintenance.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dg_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_maintenance.Location = new System.Drawing.Point(35, 181);
            this.dg_maintenance.Name = "dg_maintenance";
            this.dg_maintenance.ReadOnly = true;
            this.dg_maintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_maintenance.Size = new System.Drawing.Size(917, 429);
            this.dg_maintenance.TabIndex = 0;
            this.dg_maintenance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_maintenance_CellContentClick);
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_roomNo.Location = new System.Drawing.Point(33, 151);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(69, 17);
            this.lbl_roomNo.TabIndex = 1;
            this.lbl_roomNo.Text = "Room No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(267, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue:";
            // 
            // lbl_cost
            // 
            this.lbl_cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cost.Location = new System.Drawing.Point(815, 150);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(38, 17);
            this.lbl_cost.TabIndex = 3;
            this.lbl_cost.Text = "Cost:";
            // 
            // lbl_priority
            // 
            this.lbl_priority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.BackColor = System.Drawing.Color.Transparent;
            this.lbl_priority.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_priority.Location = new System.Drawing.Point(566, 151);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(55, 17);
            this.lbl_priority.TabIndex = 4;
            this.lbl_priority.Text = "Priority:";
            // 
            // txt_issue
            // 
            this.txt_issue.Location = new System.Drawing.Point(308, 148);
            this.txt_issue.Name = "txt_issue";
            this.txt_issue.Size = new System.Drawing.Size(100, 20);
            this.txt_issue.TabIndex = 6;
            // 
            // txt_cost
            // 
            this.txt_cost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cost.Location = new System.Drawing.Point(852, 150);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_cost.TabIndex = 7;
            // 
            // txt_priority
            // 
            this.txt_priority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_priority.Location = new System.Drawing.Point(613, 150);
            this.txt_priority.Name = "txt_priority";
            this.txt_priority.Size = new System.Drawing.Size(100, 20);
            this.txt_priority.TabIndex = 8;
            // 
            // btn_addMaintenance
            // 
            this.btn_addMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMaintenance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addMaintenance.FlatAppearance.BorderSize = 0;
            this.btn_addMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_addMaintenance.Image")));
            this.btn_addMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addMaintenance.Location = new System.Drawing.Point(736, 79);
            this.btn_addMaintenance.Name = "btn_addMaintenance";
            this.btn_addMaintenance.Size = new System.Drawing.Size(105, 46);
            this.btn_addMaintenance.TabIndex = 9;
            this.btn_addMaintenance.Text = "     Add";
            this.btn_addMaintenance.UseVisualStyleBackColor = false;
            this.btn_addMaintenance.Click += new System.EventHandler(this.btn_addMaintenance_Click);
            // 
            // btn_editMaintenance
            // 
            this.btn_editMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editMaintenance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_editMaintenance.FlatAppearance.BorderSize = 0;
            this.btn_editMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_editMaintenance.Image")));
            this.btn_editMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editMaintenance.Location = new System.Drawing.Point(847, 79);
            this.btn_editMaintenance.Name = "btn_editMaintenance";
            this.btn_editMaintenance.Size = new System.Drawing.Size(105, 46);
            this.btn_editMaintenance.TabIndex = 10;
            this.btn_editMaintenance.Text = "     Edit";
            this.btn_editMaintenance.UseVisualStyleBackColor = false;
            this.btn_editMaintenance.Click += new System.EventHandler(this.btn_editMaintenance_Click);
            // 
            // btn_updateMaintenance
            // 
            this.btn_updateMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateMaintenance.Image")));
            this.btn_updateMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateMaintenance.Location = new System.Drawing.Point(957, 616);
            this.btn_updateMaintenance.Name = "btn_updateMaintenance";
            this.btn_updateMaintenance.Size = new System.Drawing.Size(39, 43);
            this.btn_updateMaintenance.TabIndex = 11;
            this.btn_updateMaintenance.Text = "Update";
            this.btn_updateMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateMaintenance.UseVisualStyleBackColor = true;
            this.btn_updateMaintenance.Visible = false;
            // 
            // lbl_maintenanceRoomOutput
            // 
            this.lbl_maintenanceRoomOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_maintenanceRoomOutput.Location = new System.Drawing.Point(108, 150);
            this.lbl_maintenanceRoomOutput.Name = "lbl_maintenanceRoomOutput";
            this.lbl_maintenanceRoomOutput.Size = new System.Drawing.Size(100, 20);
            this.lbl_maintenanceRoomOutput.TabIndex = 13;
            // 
            // btn_maintenanceBack
            // 
            this.btn_maintenanceBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maintenanceBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maintenanceBack.BackgroundImage")));
            this.btn_maintenanceBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maintenanceBack.Location = new System.Drawing.Point(915, 12);
            this.btn_maintenanceBack.Name = "btn_maintenanceBack";
            this.btn_maintenanceBack.Size = new System.Drawing.Size(37, 35);
            this.btn_maintenanceBack.TabIndex = 14;
            this.btn_maintenanceBack.UseVisualStyleBackColor = true;
            this.btn_maintenanceBack.Click += new System.EventHandler(this.btn_maintenanceBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Maintenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Can identify issues, priority, and cost ";
            // 
            // Frm_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_maintenanceBack);
            this.Controls.Add(this.lbl_maintenanceRoomOutput);
            this.Controls.Add(this.btn_updateMaintenance);
            this.Controls.Add(this.btn_editMaintenance);
            this.Controls.Add(this.btn_addMaintenance);
            this.Controls.Add(this.txt_priority);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_issue);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.dg_maintenance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_maintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_maintenance;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.TextBox txt_issue;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_priority;
        private System.Windows.Forms.Button btn_addMaintenance;
        private System.Windows.Forms.Button btn_editMaintenance;
        private System.Windows.Forms.Button btn_updateMaintenance;
        private System.Windows.Forms.Label lbl_maintenanceRoomOutput;
        private System.Windows.Forms.Button btn_maintenanceBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}