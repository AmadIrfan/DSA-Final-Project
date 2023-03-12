
namespace OutLets.Employee
{
    partial class Route
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchShopKeeper = new System.Windows.Forms.Label();
            this.cBoxAllShopKeeper = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.lblRidersCount = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.lblLastMonthRidersCount = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblManagerAccountName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblRoute = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.lblSearchShopKeeper);
            this.panel1.Controls.Add(this.cBoxAllShopKeeper);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblRidersCount);
            this.panel1.Controls.Add(this.lblMap);
            this.panel1.Controls.Add(this.lblLastMonthRidersCount);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 510);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSearchShopKeeper
            // 
            this.lblSearchShopKeeper.AutoSize = true;
            this.lblSearchShopKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchShopKeeper.Location = new System.Drawing.Point(131, 20);
            this.lblSearchShopKeeper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchShopKeeper.Name = "lblSearchShopKeeper";
            this.lblSearchShopKeeper.Size = new System.Drawing.Size(145, 20);
            this.lblSearchShopKeeper.TabIndex = 37;
            this.lblSearchShopKeeper.Text = "Select Shopkeeper";
            // 
            // cBoxAllShopKeeper
            // 
            this.cBoxAllShopKeeper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxAllShopKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxAllShopKeeper.FormattingEnabled = true;
            this.cBoxAllShopKeeper.Location = new System.Drawing.Point(278, 16);
            this.cBoxAllShopKeeper.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxAllShopKeeper.Name = "cBoxAllShopKeeper";
            this.cBoxAllShopKeeper.Size = new System.Drawing.Size(212, 28);
            this.cBoxAllShopKeeper.TabIndex = 35;
            this.cBoxAllShopKeeper.SelectedIndexChanged += new System.EventHandler(this.cBoxAllShopKeeper_SelectedIndexChanged);
            this.cBoxAllShopKeeper.TextChanged += new System.EventHandler(this.cBoxAllShopKeeper_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.webBrowserMap);
            this.panel3.Location = new System.Drawing.Point(35, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(901, 358);
            this.panel3.TabIndex = 34;
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserMap.Location = new System.Drawing.Point(0, 0);
            this.webBrowserMap.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(901, 358);
            this.webBrowserMap.TabIndex = 0;
            // 
            // lblRidersCount
            // 
            this.lblRidersCount.AutoSize = true;
            this.lblRidersCount.BackColor = System.Drawing.Color.White;
            this.lblRidersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRidersCount.Location = new System.Drawing.Point(978, 206);
            this.lblRidersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRidersCount.Name = "lblRidersCount";
            this.lblRidersCount.Size = new System.Drawing.Size(18, 20);
            this.lblRidersCount.TabIndex = 33;
            this.lblRidersCount.Text = "0";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMap.Location = new System.Drawing.Point(34, 6);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(79, 37);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "Map";
            // 
            // lblLastMonthRidersCount
            // 
            this.lblLastMonthRidersCount.AutoSize = true;
            this.lblLastMonthRidersCount.BackColor = System.Drawing.Color.White;
            this.lblLastMonthRidersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonthRidersCount.Location = new System.Drawing.Point(978, 47);
            this.lblLastMonthRidersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastMonthRidersCount.Name = "lblLastMonthRidersCount";
            this.lblLastMonthRidersCount.Size = new System.Drawing.Size(18, 20);
            this.lblLastMonthRidersCount.TabIndex = 33;
            this.lblLastMonthRidersCount.Text = "0";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(828, 422);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 44);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(34, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 44);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblManagerAccountName);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.lblRoute);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 112);
            this.panel2.TabIndex = 11;
            // 
            // lblManagerAccountName
            // 
            this.lblManagerAccountName.AutoSize = true;
            this.lblManagerAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblManagerAccountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerAccountName.Location = new System.Drawing.Point(868, 77);
            this.lblManagerAccountName.Name = "lblManagerAccountName";
            this.lblManagerAccountName.Size = new System.Drawing.Size(55, 20);
            this.lblManagerAccountName.TabIndex = 28;
            this.lblManagerAccountName.Text = "Name";
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackgroundImage = global::OutLets.Properties.Resources.Group_3_2x;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(874, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(62, 55);
            this.panel7.TabIndex = 27;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRoute.Location = new System.Drawing.Point(27, 21);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(132, 46);
            this.lblRoute.TabIndex = 0;
            this.lblRoute.Text = "Route";
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Route";
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Route_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRidersCount;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Label lblLastMonthRidersCount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblManagerAccountName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblSearchShopKeeper;
        private System.Windows.Forms.ComboBox cBoxAllShopKeeper;
        private System.Windows.Forms.WebBrowser webBrowserMap;
    }
}