
namespace OutLets.Employee
{
    partial class Employee_Dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblManagerAccountName = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnRider = new System.Windows.Forms.Button();
            this.btnShopKeeper = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSalesManagement = new System.Windows.Forms.Button();
            this.lblmanager = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RidersPanel = new System.Windows.Forms.Panel();
            this.lblRiders = new System.Windows.Forms.Label();
            this.lblRidersCount = new System.Windows.Forms.Label();
            this.ShopKeeperPanel = new System.Windows.Forms.Panel();
            this.lblShopkeeper = new System.Windows.Forms.Label();
            this.lblShopKeepersCount = new System.Windows.Forms.Label();
            this.OrderPanel = new System.Windows.Forms.Panel();
            this.lblPendingOrdersCount = new System.Windows.Forms.Label();
            this.lblCompleteedOrdersCount = new System.Windows.Forms.Label();
            this.lblOrdersPending = new System.Windows.Forms.Label();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.lblOrdersCompleted = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.RidersPanel.SuspendLayout();
            this.ShopKeeperPanel.SuspendLayout();
            this.OrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblManagerAccountName);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnInvoices);
            this.panel2.Controls.Add(this.btnInventory);
            this.panel2.Controls.Add(this.btnRider);
            this.panel2.Controls.Add(this.btnShopKeeper);
            this.panel2.Controls.Add(this.btnOrders);
            this.panel2.Controls.Add(this.btnSalesManagement);
            this.panel2.Controls.Add(this.lblmanager);
            this.panel2.Controls.Add(this.lblDashboard);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 112);
            this.panel2.TabIndex = 1;
            // 
            // lblManagerAccountName
            // 
            this.lblManagerAccountName.AutoSize = true;
            this.lblManagerAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblManagerAccountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerAccountName.Location = new System.Drawing.Point(919, 75);
            this.lblManagerAccountName.Name = "lblManagerAccountName";
            this.lblManagerAccountName.Size = new System.Drawing.Size(87, 20);
            this.lblManagerAccountName.TabIndex = 28;
            this.lblManagerAccountName.Text = "Employee";
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackgroundImage = global::OutLets.Properties.Resources.Group_3_2x;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(933, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(62, 55);
            this.panel7.TabIndex = 27;
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInvoices.Location = new System.Drawing.Point(528, 70);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(108, 44);
            this.btnInvoices.TabIndex = 26;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInventory.Location = new System.Drawing.Point(421, 70);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(108, 44);
            this.btnInventory.TabIndex = 26;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnRider
            // 
            this.btnRider.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRider.FlatAppearance.BorderSize = 0;
            this.btnRider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRider.Location = new System.Drawing.Point(316, 70);
            this.btnRider.Name = "btnRider";
            this.btnRider.Size = new System.Drawing.Size(108, 44);
            this.btnRider.TabIndex = 26;
            this.btnRider.Text = "Riders";
            this.btnRider.UseVisualStyleBackColor = false;
            this.btnRider.Click += new System.EventHandler(this.btnRider_Click);
            // 
            // btnShopKeeper
            // 
            this.btnShopKeeper.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnShopKeeper.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShopKeeper.FlatAppearance.BorderSize = 0;
            this.btnShopKeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopKeeper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShopKeeper.Location = new System.Drawing.Point(211, 69);
            this.btnShopKeeper.Name = "btnShopKeeper";
            this.btnShopKeeper.Size = new System.Drawing.Size(108, 44);
            this.btnShopKeeper.TabIndex = 26;
            this.btnShopKeeper.Text = "Shop Keepers";
            this.btnShopKeeper.UseVisualStyleBackColor = false;
            this.btnShopKeeper.Click += new System.EventHandler(this.btnShopKeeper_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOrders.Location = new System.Drawing.Point(105, 69);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(108, 44);
            this.btnOrders.TabIndex = 26;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnSalesManagement
            // 
            this.btnSalesManagement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalesManagement.FlatAppearance.BorderSize = 0;
            this.btnSalesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesManagement.Location = new System.Drawing.Point(-1, 69);
            this.btnSalesManagement.Name = "btnSalesManagement";
            this.btnSalesManagement.Size = new System.Drawing.Size(108, 44);
            this.btnSalesManagement.TabIndex = 25;
            this.btnSalesManagement.Text = "Sales Management";
            this.btnSalesManagement.UseVisualStyleBackColor = false;
            this.btnSalesManagement.Click += new System.EventHandler(this.btnSalesManagement_Click);
            // 
            // lblmanager
            // 
            this.lblmanager.AutoSize = true;
            this.lblmanager.BackColor = System.Drawing.Color.Transparent;
            this.lblmanager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblmanager.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmanager.Location = new System.Drawing.Point(107, 47);
            this.lblmanager.Name = "lblmanager";
            this.lblmanager.Size = new System.Drawing.Size(87, 20);
            this.lblmanager.TabIndex = 1;
            this.lblmanager.Text = "Employee";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDashboard.Location = new System.Drawing.Point(18, 17);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(173, 36);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "DashBoard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.RidersPanel);
            this.panel1.Controls.Add(this.ShopKeeperPanel);
            this.panel1.Controls.Add(this.OrderPanel);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(2, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 415);
            this.panel1.TabIndex = 1;
            // 
            // RidersPanel
            // 
            this.RidersPanel.BackColor = System.Drawing.Color.White;
            this.RidersPanel.Controls.Add(this.lblRiders);
            this.RidersPanel.Controls.Add(this.lblRidersCount);
            this.RidersPanel.Location = new System.Drawing.Point(730, 112);
            this.RidersPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RidersPanel.Name = "RidersPanel";
            this.RidersPanel.Size = new System.Drawing.Size(266, 140);
            this.RidersPanel.TabIndex = 0;
            // 
            // lblRiders
            // 
            this.lblRiders.AutoSize = true;
            this.lblRiders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiders.Location = new System.Drawing.Point(19, 28);
            this.lblRiders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiders.Name = "lblRiders";
            this.lblRiders.Size = new System.Drawing.Size(55, 20);
            this.lblRiders.TabIndex = 1;
            this.lblRiders.Text = "Riders";
            // 
            // lblRidersCount
            // 
            this.lblRidersCount.AutoSize = true;
            this.lblRidersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRidersCount.Location = new System.Drawing.Point(223, 28);
            this.lblRidersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRidersCount.Name = "lblRidersCount";
            this.lblRidersCount.Size = new System.Drawing.Size(18, 20);
            this.lblRidersCount.TabIndex = 1;
            this.lblRidersCount.Text = "0";
            // 
            // ShopKeeperPanel
            // 
            this.ShopKeeperPanel.BackColor = System.Drawing.Color.White;
            this.ShopKeeperPanel.Controls.Add(this.lblShopkeeper);
            this.ShopKeeperPanel.Controls.Add(this.lblShopKeepersCount);
            this.ShopKeeperPanel.Location = new System.Drawing.Point(394, 112);
            this.ShopKeeperPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ShopKeeperPanel.Name = "ShopKeeperPanel";
            this.ShopKeeperPanel.Size = new System.Drawing.Size(266, 140);
            this.ShopKeeperPanel.TabIndex = 0;
            // 
            // lblShopkeeper
            // 
            this.lblShopkeeper.AutoSize = true;
            this.lblShopkeeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopkeeper.Location = new System.Drawing.Point(22, 28);
            this.lblShopkeeper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopkeeper.Name = "lblShopkeeper";
            this.lblShopkeeper.Size = new System.Drawing.Size(110, 20);
            this.lblShopkeeper.TabIndex = 1;
            this.lblShopkeeper.Text = "Shop Keepers";
            // 
            // lblShopKeepersCount
            // 
            this.lblShopKeepersCount.AutoSize = true;
            this.lblShopKeepersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopKeepersCount.Location = new System.Drawing.Point(226, 28);
            this.lblShopKeepersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShopKeepersCount.Name = "lblShopKeepersCount";
            this.lblShopKeepersCount.Size = new System.Drawing.Size(18, 20);
            this.lblShopKeepersCount.TabIndex = 1;
            this.lblShopKeepersCount.Text = "0";
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackColor = System.Drawing.Color.White;
            this.OrderPanel.Controls.Add(this.lblPendingOrdersCount);
            this.OrderPanel.Controls.Add(this.lblCompleteedOrdersCount);
            this.OrderPanel.Controls.Add(this.lblOrdersPending);
            this.OrderPanel.Controls.Add(this.lblOrdersCount);
            this.OrderPanel.Controls.Add(this.lblOrdersCompleted);
            this.OrderPanel.Controls.Add(this.lblOrders);
            this.OrderPanel.Location = new System.Drawing.Point(38, 112);
            this.OrderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(266, 140);
            this.OrderPanel.TabIndex = 0;
            // 
            // lblPendingOrdersCount
            // 
            this.lblPendingOrdersCount.AutoSize = true;
            this.lblPendingOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrdersCount.Location = new System.Drawing.Point(218, 105);
            this.lblPendingOrdersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPendingOrdersCount.Name = "lblPendingOrdersCount";
            this.lblPendingOrdersCount.Size = new System.Drawing.Size(18, 20);
            this.lblPendingOrdersCount.TabIndex = 1;
            this.lblPendingOrdersCount.Text = "0";
            // 
            // lblCompleteedOrdersCount
            // 
            this.lblCompleteedOrdersCount.AutoSize = true;
            this.lblCompleteedOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleteedOrdersCount.Location = new System.Drawing.Point(218, 67);
            this.lblCompleteedOrdersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompleteedOrdersCount.Name = "lblCompleteedOrdersCount";
            this.lblCompleteedOrdersCount.Size = new System.Drawing.Size(18, 20);
            this.lblCompleteedOrdersCount.TabIndex = 1;
            this.lblCompleteedOrdersCount.Text = "0";
            // 
            // lblOrdersPending
            // 
            this.lblOrdersPending.AutoSize = true;
            this.lblOrdersPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersPending.Location = new System.Drawing.Point(14, 104);
            this.lblOrdersPending.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersPending.Name = "lblOrdersPending";
            this.lblOrdersPending.Size = new System.Drawing.Size(67, 20);
            this.lblOrdersPending.TabIndex = 1;
            this.lblOrdersPending.Text = "Pending";
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersCount.Location = new System.Drawing.Point(218, 28);
            this.lblOrdersCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(18, 20);
            this.lblOrdersCount.TabIndex = 1;
            this.lblOrdersCount.Text = "0";
            // 
            // lblOrdersCompleted
            // 
            this.lblOrdersCompleted.AutoSize = true;
            this.lblOrdersCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersCompleted.Location = new System.Drawing.Point(14, 67);
            this.lblOrdersCompleted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersCompleted.Name = "lblOrdersCompleted";
            this.lblOrdersCompleted.Size = new System.Drawing.Size(86, 20);
            this.lblOrdersCompleted.TabIndex = 1;
            this.lblOrdersCompleted.Text = "Completed";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(14, 28);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(96, 20);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Total Orders";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(23, 352);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 44);
            this.btnLogout.TabIndex = 25;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Employee_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employee_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Dashboard";
            this.Load += new System.EventHandler(this.Employee_Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.RidersPanel.ResumeLayout(false);
            this.RidersPanel.PerformLayout();
            this.ShopKeeperPanel.ResumeLayout(false);
            this.ShopKeeperPanel.PerformLayout();
            this.OrderPanel.ResumeLayout(false);
            this.OrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblManagerAccountName;
        private System.Windows.Forms.Button btnSalesManagement;
        private System.Windows.Forms.Label lblmanager;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnRider;
        private System.Windows.Forms.Button btnShopKeeper;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel RidersPanel;
        private System.Windows.Forms.Panel ShopKeeperPanel;
        private System.Windows.Forms.Panel OrderPanel;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblPendingOrdersCount;
        private System.Windows.Forms.Label lblCompleteedOrdersCount;
        private System.Windows.Forms.Label lblOrdersPending;
        private System.Windows.Forms.Label lblOrdersCount;
        private System.Windows.Forms.Label lblOrdersCompleted;
        private System.Windows.Forms.Label lblShopkeeper;
        private System.Windows.Forms.Label lblShopKeepersCount;
        private System.Windows.Forms.Label lblRiders;
        private System.Windows.Forms.Label lblRidersCount;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel7;
    }
}