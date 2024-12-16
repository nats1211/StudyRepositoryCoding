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
            this.btn_addMaintenance = new System.Windows.Forms.Button();
            this.btn_editMaintenance = new System.Windows.Forms.Button();
            this.btn_updateMaintenance = new System.Windows.Forms.Button();
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
            this.dg_maintenance.Location = new System.Drawing.Point(47, 223);
            this.dg_maintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_maintenance.Name = "dg_maintenance";
            this.dg_maintenance.ReadOnly = true;
            this.dg_maintenance.RowHeadersWidth = 51;
            this.dg_maintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_maintenance.Size = new System.Drawing.Size(1223, 528);
            this.dg_maintenance.TabIndex = 0;
            this.dg_maintenance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_maintenance_CellContentClick);
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
            this.btn_addMaintenance.Location = new System.Drawing.Point(981, 97);
            this.btn_addMaintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addMaintenance.Name = "btn_addMaintenance";
            this.btn_addMaintenance.Size = new System.Drawing.Size(140, 57);
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
            this.btn_editMaintenance.Location = new System.Drawing.Point(1129, 97);
            this.btn_editMaintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editMaintenance.Name = "btn_editMaintenance";
            this.btn_editMaintenance.Size = new System.Drawing.Size(140, 57);
            this.btn_editMaintenance.TabIndex = 10;
            this.btn_editMaintenance.Text = "     Delete";
            this.btn_editMaintenance.UseVisualStyleBackColor = false;
            this.btn_editMaintenance.Click += new System.EventHandler(this.btn_editMaintenance_Click);
            // 
            // btn_updateMaintenance
            // 
            this.btn_updateMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateMaintenance.Image")));
            this.btn_updateMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateMaintenance.Location = new System.Drawing.Point(1276, 758);
            this.btn_updateMaintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_updateMaintenance.Name = "btn_updateMaintenance";
            this.btn_updateMaintenance.Size = new System.Drawing.Size(52, 53);
            this.btn_updateMaintenance.TabIndex = 11;
            this.btn_updateMaintenance.Text = "Update";
            this.btn_updateMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateMaintenance.UseVisualStyleBackColor = true;
            this.btn_updateMaintenance.Visible = false;
            // 
            // btn_maintenanceBack
            // 
            this.btn_maintenanceBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maintenanceBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maintenanceBack.BackgroundImage")));
            this.btn_maintenanceBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maintenanceBack.Location = new System.Drawing.Point(1220, 15);
            this.btn_maintenanceBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_maintenanceBack.Name = "btn_maintenanceBack";
            this.btn_maintenanceBack.Size = new System.Drawing.Size(49, 43);
            this.btn_maintenanceBack.TabIndex = 14;
            this.btn_maintenanceBack.UseVisualStyleBackColor = true;
            this.btn_maintenanceBack.Click += new System.EventHandler(this.btn_maintenanceBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 54);
            this.label2.TabIndex = 15;
            this.label2.Text = "Maintenance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Can identify issues, priority, and cost ";
            // 
            // Frm_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_maintenanceBack);
            this.Controls.Add(this.btn_updateMaintenance);
            this.Controls.Add(this.btn_editMaintenance);
            this.Controls.Add(this.btn_addMaintenance);
            this.Controls.Add(this.dg_maintenance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Maintenance";
            this.Text = "Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Frm_Maintenance_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dg_maintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_maintenance;
        private System.Windows.Forms.Button btn_addMaintenance;
        private System.Windows.Forms.Button btn_editMaintenance;
        private System.Windows.Forms.Button btn_updateMaintenance;
        private System.Windows.Forms.Button btn_maintenanceBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}