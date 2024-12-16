namespace AppartmentSystem.Maintenance
{
    partial class frm_addMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addMaintenance));
            this.lbl_room = new System.Windows.Forms.Label();
            this.cb_roomaddMaintenance = new System.Windows.Forms.ComboBox();
            this.btn_addMaintenanceInfo = new System.Windows.Forms.Button();
            this.btn_addmaintenanceSave = new System.Windows.Forms.Button();
            this.btn_addmaintenanceback = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.lbl_subheader = new System.Windows.Forms.Label();
            this.lbl_expenseType = new System.Windows.Forms.Label();
            this.cb_addExpenseType = new System.Windows.Forms.ComboBox();
            this.lbl_addDate = new System.Windows.Forms.Label();
            this.dp_addMaintenance = new System.Windows.Forms.DateTimePicker();
            this.lbl_addAmount = new System.Windows.Forms.Label();
            this.txt_addAmount = new System.Windows.Forms.TextBox();
            this.lbl_descriptionTitle = new System.Windows.Forms.Label();
            this.txt_addDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.BackColor = System.Drawing.Color.Transparent;
            this.lbl_room.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_room.Location = new System.Drawing.Point(679, 196);
            this.lbl_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(47, 17);
            this.lbl_room.TabIndex = 0;
            this.lbl_room.Text = "House";
            // 
            // cb_roomaddMaintenance
            // 
            this.cb_roomaddMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_roomaddMaintenance.FormattingEnabled = true;
            this.cb_roomaddMaintenance.Location = new System.Drawing.Point(731, 192);
            this.cb_roomaddMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.cb_roomaddMaintenance.Name = "cb_roomaddMaintenance";
            this.cb_roomaddMaintenance.Size = new System.Drawing.Size(160, 25);
            this.cb_roomaddMaintenance.TabIndex = 1;
            // 
            // btn_addMaintenanceInfo
            // 
            this.btn_addMaintenanceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMaintenanceInfo.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addMaintenanceInfo.FlatAppearance.BorderSize = 0;
            this.btn_addMaintenanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMaintenanceInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMaintenanceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_addMaintenanceInfo.Image")));
            this.btn_addMaintenanceInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addMaintenanceInfo.Location = new System.Drawing.Point(1139, 107);
            this.btn_addMaintenanceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addMaintenanceInfo.Name = "btn_addMaintenanceInfo";
            this.btn_addMaintenanceInfo.Size = new System.Drawing.Size(140, 60);
            this.btn_addMaintenanceInfo.TabIndex = 3;
            this.btn_addMaintenanceInfo.Text = "   Info";
            this.btn_addMaintenanceInfo.UseVisualStyleBackColor = false;
            // 
            // btn_addmaintenanceSave
            // 
            this.btn_addmaintenanceSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addmaintenanceSave.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_addmaintenanceSave.FlatAppearance.BorderSize = 0;
            this.btn_addmaintenanceSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmaintenanceSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmaintenanceSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_addmaintenanceSave.Image")));
            this.btn_addmaintenanceSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addmaintenanceSave.Location = new System.Drawing.Point(991, 107);
            this.btn_addmaintenanceSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addmaintenanceSave.Name = "btn_addmaintenanceSave";
            this.btn_addmaintenanceSave.Size = new System.Drawing.Size(140, 60);
            this.btn_addmaintenanceSave.TabIndex = 4;
            this.btn_addmaintenanceSave.Text = "      Save";
            this.btn_addmaintenanceSave.UseVisualStyleBackColor = false;
            this.btn_addmaintenanceSave.Click += new System.EventHandler(this.btn_addmaintenanceSave_Click);
            // 
            // btn_addmaintenanceback
            // 
            this.btn_addmaintenanceback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addmaintenanceback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addmaintenanceback.BackgroundImage")));
            this.btn_addmaintenanceback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addmaintenanceback.Location = new System.Drawing.Point(1229, 16);
            this.btn_addmaintenanceback.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addmaintenanceback.Name = "btn_addmaintenanceback";
            this.btn_addmaintenanceback.Size = new System.Drawing.Size(49, 46);
            this.btn_addmaintenanceback.TabIndex = 5;
            this.btn_addmaintenanceback.UseVisualStyleBackColor = true;
            this.btn_addmaintenanceback.Click += new System.EventHandler(this.btn_addmaintenanceback_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.BackColor = System.Drawing.Color.Transparent;
            this.label_header.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.Location = new System.Drawing.Point(61, 16);
            this.label_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(284, 45);
            this.label_header.TabIndex = 6;
            this.label_header.Text = "Add Maintenance";
            // 
            // lbl_subheader
            // 
            this.lbl_subheader.AutoSize = true;
            this.lbl_subheader.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subheader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subheader.Location = new System.Drawing.Point(72, 80);
            this.lbl_subheader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_subheader.Name = "lbl_subheader";
            this.lbl_subheader.Size = new System.Drawing.Size(277, 15);
            this.lbl_subheader.TabIndex = 7;
            this.lbl_subheader.Text = "Can add and show Information about Maintenance";
            // 
            // lbl_expenseType
            // 
            this.lbl_expenseType.AutoSize = true;
            this.lbl_expenseType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_expenseType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_expenseType.Location = new System.Drawing.Point(85, 196);
            this.lbl_expenseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_expenseType.Name = "lbl_expenseType";
            this.lbl_expenseType.Size = new System.Drawing.Size(90, 17);
            this.lbl_expenseType.TabIndex = 8;
            this.lbl_expenseType.Text = "Expense Type";
            // 
            // cb_addExpenseType
            // 
            this.cb_addExpenseType.FormattingEnabled = true;
            this.cb_addExpenseType.Location = new System.Drawing.Point(207, 192);
            this.cb_addExpenseType.Margin = new System.Windows.Forms.Padding(4);
            this.cb_addExpenseType.Name = "cb_addExpenseType";
            this.cb_addExpenseType.Size = new System.Drawing.Size(160, 25);
            this.cb_addExpenseType.TabIndex = 9;
            // 
            // lbl_addDate
            // 
            this.lbl_addDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_addDate.AutoSize = true;
            this.lbl_addDate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addDate.Location = new System.Drawing.Point(969, 196);
            this.lbl_addDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addDate.Name = "lbl_addDate";
            this.lbl_addDate.Size = new System.Drawing.Size(36, 17);
            this.lbl_addDate.TabIndex = 10;
            this.lbl_addDate.Text = "Date";
            // 
            // dp_addMaintenance
            // 
            this.dp_addMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_addMaintenance.Location = new System.Drawing.Point(1013, 193);
            this.dp_addMaintenance.Margin = new System.Windows.Forms.Padding(4);
            this.dp_addMaintenance.Name = "dp_addMaintenance";
            this.dp_addMaintenance.Size = new System.Drawing.Size(265, 25);
            this.dp_addMaintenance.TabIndex = 11;
            // 
            // lbl_addAmount
            // 
            this.lbl_addAmount.AutoSize = true;
            this.lbl_addAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbl_addAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addAmount.Location = new System.Drawing.Point(436, 196);
            this.lbl_addAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_addAmount.Name = "lbl_addAmount";
            this.lbl_addAmount.Size = new System.Drawing.Size(58, 17);
            this.lbl_addAmount.TabIndex = 12;
            this.lbl_addAmount.Text = "Amount";
            // 
            // txt_addAmount
            // 
            this.txt_addAmount.Location = new System.Drawing.Point(502, 192);
            this.txt_addAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_addAmount.Name = "txt_addAmount";
            this.txt_addAmount.Size = new System.Drawing.Size(132, 25);
            this.txt_addAmount.TabIndex = 13;
            // 
            // lbl_descriptionTitle
            // 
            this.lbl_descriptionTitle.AutoSize = true;
            this.lbl_descriptionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descriptionTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descriptionTitle.Location = new System.Drawing.Point(68, 267);
            this.lbl_descriptionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descriptionTitle.Name = "lbl_descriptionTitle";
            this.lbl_descriptionTitle.Size = new System.Drawing.Size(164, 37);
            this.lbl_descriptionTitle.TabIndex = 14;
            this.lbl_descriptionTitle.Text = "Description:\r\n";
            // 
            // txt_addDescription
            // 
            this.txt_addDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addDescription.Location = new System.Drawing.Point(74, 307);
            this.txt_addDescription.Multiline = true;
            this.txt_addDescription.Name = "txt_addDescription";
            this.txt_addDescription.Size = new System.Drawing.Size(1205, 316);
            this.txt_addDescription.TabIndex = 15;
            // 
            // frm_addMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.txt_addDescription);
            this.Controls.Add(this.lbl_descriptionTitle);
            this.Controls.Add(this.txt_addAmount);
            this.Controls.Add(this.lbl_addAmount);
            this.Controls.Add(this.dp_addMaintenance);
            this.Controls.Add(this.lbl_addDate);
            this.Controls.Add(this.cb_addExpenseType);
            this.Controls.Add(this.lbl_expenseType);
            this.Controls.Add(this.lbl_subheader);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.btn_addmaintenanceback);
            this.Controls.Add(this.btn_addmaintenanceSave);
            this.Controls.Add(this.btn_addMaintenanceInfo);
            this.Controls.Add(this.cb_roomaddMaintenance);
            this.Controls.Add(this.lbl_room);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addMaintenance";
            this.Load += new System.EventHandler(this.frm_addMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.ComboBox cb_roomaddMaintenance;
        private System.Windows.Forms.Button btn_addMaintenanceInfo;
        private System.Windows.Forms.Button btn_addmaintenanceSave;
        private System.Windows.Forms.Button btn_addmaintenanceback;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label lbl_subheader;
        private System.Windows.Forms.Label lbl_expenseType;
        private System.Windows.Forms.ComboBox cb_addExpenseType;
        private System.Windows.Forms.Label lbl_addDate;
        private System.Windows.Forms.DateTimePicker dp_addMaintenance;
        private System.Windows.Forms.Label lbl_addAmount;
        private System.Windows.Forms.TextBox txt_addAmount;
        private System.Windows.Forms.Label lbl_descriptionTitle;
        private System.Windows.Forms.TextBox txt_addDescription;
    }
}