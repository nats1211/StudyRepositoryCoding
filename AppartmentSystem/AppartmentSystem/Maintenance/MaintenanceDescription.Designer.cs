namespace AppartmentSystem.Maintenance
{
    partial class MaintenanceDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceDescription));
            this.lbl_infoOutput = new System.Windows.Forms.Label();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.btn_backDesc = new System.Windows.Forms.Button();
            this.lbl_subheader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_infoOutput
            // 
            this.lbl_infoOutput.BackColor = System.Drawing.Color.White;
            this.lbl_infoOutput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infoOutput.Location = new System.Drawing.Point(39, 87);
            this.lbl_infoOutput.Name = "lbl_infoOutput";
            this.lbl_infoOutput.Size = new System.Drawing.Size(719, 310);
            this.lbl_infoOutput.TabIndex = 0;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(35, 9);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(338, 37);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Maintenance Description\r\n";
            // 
            // btn_backDesc
            // 
            this.btn_backDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_backDesc.BackgroundImage")));
            this.btn_backDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_backDesc.Location = new System.Drawing.Point(718, 17);
            this.btn_backDesc.Name = "btn_backDesc";
            this.btn_backDesc.Size = new System.Drawing.Size(40, 35);
            this.btn_backDesc.TabIndex = 2;
            this.btn_backDesc.UseVisualStyleBackColor = true;
            this.btn_backDesc.Click += new System.EventHandler(this.btn_backDesc_Click);
            // 
            // lbl_subheader
            // 
            this.lbl_subheader.AutoSize = true;
            this.lbl_subheader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subheader.Location = new System.Drawing.Point(42, 50);
            this.lbl_subheader.Name = "lbl_subheader";
            this.lbl_subheader.Size = new System.Drawing.Size(167, 15);
            this.lbl_subheader.TabIndex = 3;
            this.lbl_subheader.Text = "Show Details about Maintance";
            // 
            // MaintenanceDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_subheader);
            this.Controls.Add(this.btn_backDesc);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.lbl_infoOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MaintenanceDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaintenanceDescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_infoOutput;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_backDesc;
        private System.Windows.Forms.Label lbl_subheader;
    }
}