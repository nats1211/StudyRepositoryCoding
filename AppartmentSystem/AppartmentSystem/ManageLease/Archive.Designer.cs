namespace AppartmentSystem.ManageRoom
{
    partial class frm_Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Archive));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_archive = new System.Windows.Forms.Label();
            this.btn_archiveBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(963, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_archive
            // 
            this.lbl_archive.AutoSize = true;
            this.lbl_archive.BackColor = System.Drawing.Color.Transparent;
            this.lbl_archive.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_archive.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_archive.Location = new System.Drawing.Point(12, 19);
            this.lbl_archive.Name = "lbl_archive";
            this.lbl_archive.Size = new System.Drawing.Size(131, 45);
            this.lbl_archive.TabIndex = 1;
            this.lbl_archive.Text = "History";
            // 
            // btn_archiveBack
            // 
            this.btn_archiveBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_archiveBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_archiveBack.BackgroundImage")));
            this.btn_archiveBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_archiveBack.Location = new System.Drawing.Point(943, 19);
            this.btn_archiveBack.Name = "btn_archiveBack";
            this.btn_archiveBack.Size = new System.Drawing.Size(40, 35);
            this.btn_archiveBack.TabIndex = 2;
            this.btn_archiveBack.UseVisualStyleBackColor = true;
            this.btn_archiveBack.Click += new System.EventHandler(this.btn_archiveBack_Click);
            // 
            // frm_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_archiveBack);
            this.Controls.Add(this.lbl_archive);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_archive;
        private System.Windows.Forms.Button btn_archiveBack;
    }
}