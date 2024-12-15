namespace AppartmentSystem
{
    partial class Frm_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SignUp));
            this.lbl_CreateAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_CreateAcc = new System.Windows.Forms.Button();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_ConfirmPass = new System.Windows.Forms.TextBox();
            this.btn_back_signup = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CreateAcc
            // 
            this.lbl_CreateAcc.AutoSize = true;
            this.lbl_CreateAcc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CreateAcc.Font = new System.Drawing.Font("Calisto MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CreateAcc.ForeColor = System.Drawing.Color.Black;
            this.lbl_CreateAcc.Location = new System.Drawing.Point(82, 22);
            this.lbl_CreateAcc.Name = "lbl_CreateAcc";
            this.lbl_CreateAcc.Size = new System.Drawing.Size(373, 40);
            this.lbl_CreateAcc.TabIndex = 0;
            this.lbl_CreateAcc.Text = "Create A New Account";
            this.lbl_CreateAcc.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(255, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(16, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(18, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(255, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Pass:";
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.BackColor = System.Drawing.Color.Silver;
            this.btn_CreateAcc.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateAcc.Image = ((System.Drawing.Image)(resources.GetObject("btn_CreateAcc.Image")));
            this.btn_CreateAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CreateAcc.Location = new System.Drawing.Point(315, 293);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Size = new System.Drawing.Size(156, 65);
            this.btn_CreateAcc.TabIndex = 6;
            this.btn_CreateAcc.Text = "Create Account";
            this.btn_CreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateAcc.UseVisualStyleBackColor = false;
            this.btn_CreateAcc.Click += new System.EventHandler(this.btn_CreateAcc_Click);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.BackColor = System.Drawing.Color.Silver;
            this.txt_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FirstName.Location = new System.Drawing.Point(89, 120);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(153, 20);
            this.txt_FirstName.TabIndex = 7;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Silver;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Location = new System.Drawing.Point(89, 182);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(153, 20);
            this.txt_Username.TabIndex = 8;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Silver;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Location = new System.Drawing.Point(89, 235);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(153, 20);
            this.txt_Password.TabIndex = 9;
            // 
            // txt_LastName
            // 
            this.txt_LastName.BackColor = System.Drawing.Color.Silver;
            this.txt_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LastName.Location = new System.Drawing.Point(322, 120);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(149, 20);
            this.txt_LastName.TabIndex = 10;
            // 
            // txt_ConfirmPass
            // 
            this.txt_ConfirmPass.BackColor = System.Drawing.Color.Silver;
            this.txt_ConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmPass.Location = new System.Drawing.Point(343, 236);
            this.txt_ConfirmPass.Name = "txt_ConfirmPass";
            this.txt_ConfirmPass.Size = new System.Drawing.Size(128, 20);
            this.txt_ConfirmPass.TabIndex = 11;
            this.txt_ConfirmPass.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_back_signup
            // 
            this.btn_back_signup.BackColor = System.Drawing.Color.Silver;
            this.btn_back_signup.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_signup.Image = ((System.Drawing.Image)(resources.GetObject("btn_back_signup.Image")));
            this.btn_back_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back_signup.Location = new System.Drawing.Point(69, 293);
            this.btn_back_signup.Name = "btn_back_signup";
            this.btn_back_signup.Size = new System.Drawing.Size(156, 65);
            this.btn_back_signup.TabIndex = 12;
            this.btn_back_signup.Text = "      Back";
            this.btn_back_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back_signup.UseVisualStyleBackColor = false;
            this.btn_back_signup.Click += new System.EventHandler(this.btn_back_signup_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_CreateAcc);
            this.panel1.Controls.Add(this.btn_CreateAcc);
            this.panel1.Controls.Add(this.btn_back_signup);
            this.panel1.Controls.Add(this.txt_FirstName);
            this.panel1.Controls.Add(this.txt_ConfirmPass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_LastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(284, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 387);
            this.panel1.TabIndex = 13;
            // 
            // Frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Frm_SignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_CreateAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_CreateAcc;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_ConfirmPass;
        private System.Windows.Forms.Button btn_back_signup;
        private System.Windows.Forms.Panel panel1;
    }
}