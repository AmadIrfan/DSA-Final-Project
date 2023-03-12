namespace OutLets
{
    partial class employee
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRole = new System.Windows.Forms.Label();
            this.cBoxRole = new System.Windows.Forms.ComboBox();
            this.gridViewEmployee = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblManagerAccountName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.LinkLabel();
            this.lblEmployeePageName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(69, 512);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(99, 48);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.cBoxRole);
            this.panel1.Controls.Add(this.gridViewEmployee);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 591);
            this.panel1.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(190, 140);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(91, 20);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Select Role";
            // 
            // cBoxRole
            // 
            this.cBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxRole.FormattingEnabled = true;
            this.cBoxRole.ItemHeight = 20;
            this.cBoxRole.Location = new System.Drawing.Point(289, 136);
            this.cBoxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBoxRole.Name = "cBoxRole";
            this.cBoxRole.Size = new System.Drawing.Size(216, 28);
            this.cBoxRole.TabIndex = 27;
            this.cBoxRole.SelectedIndexChanged += new System.EventHandler(this.cBoxRole_SelectedIndexChanged);
            this.cBoxRole.TextChanged += new System.EventHandler(this.cBoxRole_TextChanged);
            this.cBoxRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cBoxRole_KeyDown);
            // 
            // gridViewEmployee
            // 
            this.gridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.gridViewEmployee.Location = new System.Drawing.Point(69, 181);
            this.gridViewEmployee.Name = "gridViewEmployee";
            this.gridViewEmployee.Size = new System.Drawing.Size(928, 232);
            this.gridViewEmployee.TabIndex = 26;
            this.gridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewEmployee_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblManagerAccountName);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.lblLogOut);
            this.panel2.Controls.Add(this.lblEmployeePageName);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1129, 92);
            this.panel2.TabIndex = 25;
            // 
            // lblManagerAccountName
            // 
            this.lblManagerAccountName.AutoSize = true;
            this.lblManagerAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblManagerAccountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerAccountName.Location = new System.Drawing.Point(960, 59);
            this.lblManagerAccountName.Name = "lblManagerAccountName";
            this.lblManagerAccountName.Size = new System.Drawing.Size(79, 20);
            this.lblManagerAccountName.TabIndex = 32;
            this.lblManagerAccountName.Text = "Manager";
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackgroundImage = global::OutLets.Properties.Resources.Group_3_2x;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(964, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(63, 39);
            this.panel7.TabIndex = 31;
            // 
            // lblLogOut
            // 
            this.lblLogOut.ActiveLinkColor = System.Drawing.Color.White;
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.DisabledLinkColor = System.Drawing.Color.White;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblLogOut.LinkColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(880, 58);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(73, 20);
            this.lblLogOut.TabIndex = 2;
            this.lblLogOut.TabStop = true;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogOut_LinkClicked);
            // 
            // lblEmployeePageName
            // 
            this.lblEmployeePageName.AutoSize = true;
            this.lblEmployeePageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePageName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmployeePageName.Location = new System.Drawing.Point(12, 26);
            this.lblEmployeePageName.Name = "lblEmployeePageName";
            this.lblEmployeePageName.Size = new System.Drawing.Size(142, 31);
            this.lblEmployeePageName.TabIndex = 0;
            this.lblEmployeePageName.Text = "Employee";
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 582);
            this.Controls.Add(this.panel1);
            this.Name = "employee";
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblLogOut;
        private System.Windows.Forms.Label lblEmployeePageName;
        private System.Windows.Forms.Label lblManagerAccountName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView gridViewEmployee;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox cBoxRole;
        private System.Windows.Forms.Label lblRole;
    }
}