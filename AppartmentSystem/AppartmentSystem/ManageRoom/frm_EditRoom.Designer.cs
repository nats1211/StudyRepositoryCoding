namespace AppartmentSystem.ManageRoom
{
    partial class frm_EditRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditRoom));
            this.lbl_editroomheader = new System.Windows.Forms.Label();
            this.lbl_editRoomsubheader = new System.Windows.Forms.Label();
            this.btn_editRoomBack = new System.Windows.Forms.Button();
            this.lbl_editRoomroom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_editRoomtenant = new System.Windows.Forms.Label();
            this.lbl_editRoomprice = new System.Windows.Forms.Label();
            this.txt_editRoomprice = new System.Windows.Forms.TextBox();
            this.btn_editRoomSave = new System.Windows.Forms.Button();
            this.btn_editRoomCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TenantName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_editroomheader
            // 
            this.lbl_editroomheader.AutoSize = true;
            this.lbl_editroomheader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editroomheader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editroomheader.Location = new System.Drawing.Point(13, 13);
            this.lbl_editroomheader.Name = "lbl_editroomheader";
            this.lbl_editroomheader.Size = new System.Drawing.Size(176, 45);
            this.lbl_editroomheader.TabIndex = 0;
            this.lbl_editroomheader.Text = "Edit Room";
            // 
            // lbl_editRoomsubheader
            // 
            this.lbl_editRoomsubheader.AutoSize = true;
            this.lbl_editRoomsubheader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomsubheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomsubheader.Location = new System.Drawing.Point(21, 62);
            this.lbl_editRoomsubheader.Name = "lbl_editRoomsubheader";
            this.lbl_editRoomsubheader.Size = new System.Drawing.Size(140, 15);
            this.lbl_editRoomsubheader.TabIndex = 1;
            this.lbl_editRoomsubheader.Text = "Can Edit Details Of Room";
            // 
            // btn_editRoomBack
            // 
            this.btn_editRoomBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editRoomBack.BackgroundImage")));
            this.btn_editRoomBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_editRoomBack.Location = new System.Drawing.Point(715, 24);
            this.btn_editRoomBack.Name = "btn_editRoomBack";
            this.btn_editRoomBack.Size = new System.Drawing.Size(45, 40);
            this.btn_editRoomBack.TabIndex = 2;
            this.btn_editRoomBack.UseVisualStyleBackColor = true;
            this.btn_editRoomBack.Click += new System.EventHandler(this.btn_editRoomBack_Click);
            // 
            // lbl_editRoomroom
            // 
            this.lbl_editRoomroom.AutoSize = true;
            this.lbl_editRoomroom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomroom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomroom.Location = new System.Drawing.Point(55, 169);
            this.lbl_editRoomroom.Name = "lbl_editRoomroom";
            this.lbl_editRoomroom.Size = new System.Drawing.Size(53, 20);
            this.lbl_editRoomroom.TabIndex = 3;
            this.lbl_editRoomroom.Text = "Room:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbl_editRoomtenant
            // 
            this.lbl_editRoomtenant.AutoSize = true;
            this.lbl_editRoomtenant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomtenant.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomtenant.Location = new System.Drawing.Point(51, 216);
            this.lbl_editRoomtenant.Name = "lbl_editRoomtenant";
            this.lbl_editRoomtenant.Size = new System.Drawing.Size(59, 20);
            this.lbl_editRoomtenant.TabIndex = 5;
            this.lbl_editRoomtenant.Text = "Tenant:";
            // 
            // lbl_editRoomprice
            // 
            this.lbl_editRoomprice.AutoSize = true;
            this.lbl_editRoomprice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_editRoomprice.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editRoomprice.Location = new System.Drawing.Point(60, 264);
            this.lbl_editRoomprice.Name = "lbl_editRoomprice";
            this.lbl_editRoomprice.Size = new System.Drawing.Size(47, 20);
            this.lbl_editRoomprice.TabIndex = 7;
            this.lbl_editRoomprice.Text = "Price:";
            // 
            // txt_editRoomprice
            // 
            this.txt_editRoomprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_editRoomprice.Location = new System.Drawing.Point(113, 261);
            this.txt_editRoomprice.Name = "txt_editRoomprice";
            this.txt_editRoomprice.Size = new System.Drawing.Size(100, 26);
            this.txt_editRoomprice.TabIndex = 8;
            this.txt_editRoomprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_editRoomprice_KeyPress);
            // 
            // btn_editRoomSave
            // 
            this.btn_editRoomSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_editRoomSave.FlatAppearance.BorderSize = 0;
            this.btn_editRoomSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editRoomSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRoomSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_editRoomSave.Image")));
            this.btn_editRoomSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editRoomSave.Location = new System.Drawing.Point(555, 380);
            this.btn_editRoomSave.Name = "btn_editRoomSave";
            this.btn_editRoomSave.Size = new System.Drawing.Size(105, 46);
            this.btn_editRoomSave.TabIndex = 9;
            this.btn_editRoomSave.Text = "        Save";
            this.btn_editRoomSave.UseVisualStyleBackColor = false;
            this.btn_editRoomSave.Click += new System.EventHandler(this.btn_editRoomSave_Click);
            // 
            // btn_editRoomCancel
            // 
            this.btn_editRoomCancel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_editRoomCancel.FlatAppearance.BorderSize = 0;
            this.btn_editRoomCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editRoomCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRoomCancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_editRoomCancel.Image")));
            this.btn_editRoomCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editRoomCancel.Location = new System.Drawing.Point(666, 380);
            this.btn_editRoomCancel.Name = "btn_editRoomCancel";
            this.btn_editRoomCancel.Size = new System.Drawing.Size(105, 46);
            this.btn_editRoomCancel.TabIndex = 10;
            this.btn_editRoomCancel.Text = "     Cancel";
            this.btn_editRoomCancel.UseVisualStyleBackColor = false;
            this.btn_editRoomCancel.Click += new System.EventHandler(this.btn_editRoomCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(276, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 179);
            this.label1.TabIndex = 12;
            // 
            // cb_TenantName
            // 
            this.cb_TenantName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_TenantName.FormattingEnabled = true;
            this.cb_TenantName.Location = new System.Drawing.Point(113, 216);
            this.cb_TenantName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_TenantName.Name = "cb_TenantName";
            this.cb_TenantName.Size = new System.Drawing.Size(100, 21);
            this.cb_TenantName.TabIndex = 22;
            // 
            // frm_EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_TenantName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_editRoomCancel);
            this.Controls.Add(this.btn_editRoomSave);
            this.Controls.Add(this.txt_editRoomprice);
            this.Controls.Add(this.lbl_editRoomprice);
            this.Controls.Add(this.lbl_editRoomtenant);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_editRoomroom);
            this.Controls.Add(this.btn_editRoomBack);
            this.Controls.Add(this.lbl_editRoomsubheader);
            this.Controls.Add(this.lbl_editroomheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_EditRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EditRoom";
            this.Load += new System.EventHandler(this.frm_EditRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_editroomheader;
        private System.Windows.Forms.Label lbl_editRoomsubheader;
        private System.Windows.Forms.Button btn_editRoomBack;
        private System.Windows.Forms.Label lbl_editRoomroom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_editRoomtenant;
        private System.Windows.Forms.Label lbl_editRoomprice;
        private System.Windows.Forms.TextBox txt_editRoomprice;
        private System.Windows.Forms.Button btn_editRoomSave;
        private System.Windows.Forms.Button btn_editRoomCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TenantName;
    }
}