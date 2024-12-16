namespace AppartmentSystem.ManageLease
{
    partial class frm_addTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addTenant));
            this.cb_TenantName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addTenantCancel = new System.Windows.Forms.Button();
            this.btn_addTenantSave = new System.Windows.Forms.Button();
            this.lbl_editRoomtenant = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_editRoomroom = new System.Windows.Forms.Label();
            this.btn_addtenantBack = new System.Windows.Forms.Button();
            this.lbl_editRoomsubheader = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_TenantName
            // 
            this.cb_TenantName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TenantName.FormattingEnabled = true;
            this.cb_TenantName.Location = new System.Drawing.Point(121, 222);
            this.cb_TenantName.Margin = new System.Windows.Forms.Padding(4);
            this.cb_TenantName.Name = "cb_TenantName";
            this.cb_TenantName.Size = new System.Drawing.Size(100, 21);
            this.cb_TenantName.TabIndex = 34;
            this.cb_TenantName.SelectedIndexChanged += new System.EventHandler(this.cb_TenantName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(284, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 179);
            this.label1.TabIndex = 33;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_addTenantCancel
            // 
            this.btn_addTenantCancel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addTenantCancel.FlatAppearance.BorderSize = 0;
            this.btn_addTenantCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTenantCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTenantCancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_addTenantCancel.Image")));
            this.btn_addTenantCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addTenantCancel.Location = new System.Drawing.Point(674, 386);
            this.btn_addTenantCancel.Name = "btn_addTenantCancel";
            this.btn_addTenantCancel.Size = new System.Drawing.Size(105, 46);
            this.btn_addTenantCancel.TabIndex = 32;
            this.btn_addTenantCancel.Text = "     Cancel";
            this.btn_addTenantCancel.UseVisualStyleBackColor = false;
            this.btn_addTenantCancel.Click += new System.EventHandler(this.btn_editRoomCancel_Click);
            // 
            // btn_addTenantSave
            // 
            this.btn_addTenantSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addTenantSave.FlatAppearance.BorderSize = 0;
            this.btn_addTenantSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTenantSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTenantSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_addTenantSave.Image")));
            this.btn_addTenantSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addTenantSave.Location = new System.Drawing.Point(563, 386);
            this.btn_addTenantSave.Name = "btn_addTenantSave";
            this.btn_addTenantSave.Size = new System.Drawing.Size(105, 46);
            this.btn_addTenantSave.TabIndex = 31;
            this.btn_addTenantSave.Text = "        Save";
            this.btn_addTenantSave.UseVisualStyleBackColor = false;
            this.btn_addTenantSave.Click += new System.EventHandler(this.btn_editRoomSave_Click);
            // 
            // lbl_editRoomtenant
            // 
            this.lbl_editRoomtenant.AutoSize = true;
            this.lbl_editRoomtenant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomtenant.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomtenant.Location = new System.Drawing.Point(59, 222);
            this.lbl_editRoomtenant.Name = "lbl_editRoomtenant";
            this.lbl_editRoomtenant.Size = new System.Drawing.Size(59, 20);
            this.lbl_editRoomtenant.TabIndex = 28;
            this.lbl_editRoomtenant.Text = "Tenant:";
            this.lbl_editRoomtenant.Click += new System.EventHandler(this.lbl_editRoomtenant_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_editRoomroom
            // 
            this.lbl_editRoomroom.AutoSize = true;
            this.lbl_editRoomroom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomroom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomroom.Location = new System.Drawing.Point(37, 175);
            this.lbl_editRoomroom.Name = "lbl_editRoomroom";
            this.lbl_editRoomroom.Size = new System.Drawing.Size(81, 20);
            this.lbl_editRoomroom.TabIndex = 26;
            this.lbl_editRoomroom.Text = "House No:";
            this.lbl_editRoomroom.Click += new System.EventHandler(this.lbl_editRoomroom_Click);
            // 
            // btn_addtenantBack
            // 
            this.btn_addtenantBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addtenantBack.BackgroundImage")));
            this.btn_addtenantBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addtenantBack.Location = new System.Drawing.Point(723, 30);
            this.btn_addtenantBack.Name = "btn_addtenantBack";
            this.btn_addtenantBack.Size = new System.Drawing.Size(45, 40);
            this.btn_addtenantBack.TabIndex = 25;
            this.btn_addtenantBack.UseVisualStyleBackColor = true;
            this.btn_addtenantBack.Click += new System.EventHandler(this.btn_editRoomBack_Click);
            // 
            // lbl_editRoomsubheader
            // 
            this.lbl_editRoomsubheader.AutoSize = true;
            this.lbl_editRoomsubheader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomsubheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomsubheader.Location = new System.Drawing.Point(29, 68);
            this.lbl_editRoomsubheader.Name = "lbl_editRoomsubheader";
            this.lbl_editRoomsubheader.Size = new System.Drawing.Size(89, 15);
            this.lbl_editRoomsubheader.TabIndex = 24;
            this.lbl_editRoomsubheader.Text = "Can add Tenant";
            this.lbl_editRoomsubheader.Click += new System.EventHandler(this.lbl_editRoomsubheader_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(21, 19);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(192, 45);
            this.lbl_header.TabIndex = 23;
            this.lbl_header.Text = "Add Tenant";
            this.lbl_header.Click += new System.EventHandler(this.lbl_editroomheader_Click);
            // 
            // frm_addTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_TenantName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addTenantCancel);
            this.Controls.Add(this.btn_addTenantSave);
            this.Controls.Add(this.lbl_editRoomtenant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_editRoomroom);
            this.Controls.Add(this.btn_addtenantBack);
            this.Controls.Add(this.lbl_editRoomsubheader);
            this.Controls.Add(this.lbl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addTenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addTenant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_TenantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addTenantCancel;
        private System.Windows.Forms.Button btn_addTenantSave;
        private System.Windows.Forms.Label lbl_editRoomtenant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_editRoomroom;
        private System.Windows.Forms.Button btn_addtenantBack;
        private System.Windows.Forms.Label lbl_editRoomsubheader;
        private System.Windows.Forms.Label lbl_header;
    }
}