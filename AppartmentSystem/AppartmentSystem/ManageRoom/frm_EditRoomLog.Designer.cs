namespace AppartmentSystem.ManageRoom
{
    partial class frm_EditRoomLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditRoomLog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_editroomLog = new System.Windows.Forms.DataGridView();
            this.btn_editLogback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_editroomLog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Log ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Can show edit history";
            // 
            // dg_editroomLog
            // 
            this.dg_editroomLog.AllowUserToAddRows = false;
            this.dg_editroomLog.AllowUserToDeleteRows = false;
            this.dg_editroomLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_editroomLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_editroomLog.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg_editroomLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_editroomLog.Location = new System.Drawing.Point(36, 115);
            this.dg_editroomLog.Name = "dg_editroomLog";
            this.dg_editroomLog.ReadOnly = true;
            this.dg_editroomLog.Size = new System.Drawing.Size(729, 291);
            this.dg_editroomLog.TabIndex = 2;
            // 
            // btn_editLogback
            // 
            this.btn_editLogback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editLogback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editLogback.BackgroundImage")));
            this.btn_editLogback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editLogback.Location = new System.Drawing.Point(720, 24);
            this.btn_editLogback.Name = "btn_editLogback";
            this.btn_editLogback.Size = new System.Drawing.Size(45, 40);
            this.btn_editLogback.TabIndex = 3;
            this.btn_editLogback.UseVisualStyleBackColor = true;
            this.btn_editLogback.Click += new System.EventHandler(this.btn_editLogback_Click);
            // 
            // frm_EditRoomLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_editLogback);
            this.Controls.Add(this.dg_editroomLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditRoomLog";
            this.Text = "frm_EditRoomLog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dg_editroomLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dg_editroomLog;
        private System.Windows.Forms.Button btn_editLogback;
    }
}