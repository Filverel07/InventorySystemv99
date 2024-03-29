﻿namespace InventorySystem1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts_Login = new System.Windows.Forms.ToolStripButton();
            this.ts_stocks = new System.Windows.Forms.ToolStripButton();
            this.ts_StockOut = new System.Windows.Forms.ToolStripButton();
            this.ts_Return = new System.Windows.Forms.ToolStripButton();
            this.ts_ManageUsers = new System.Windows.Forms.ToolStripButton();
            this.ts_Report = new System.Windows.Forms.ToolStripButton();
            this.ts_settings = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_suppliers = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(161, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1156, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts_Login
            // 
            this.ts_Login.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Login.Image = ((System.Drawing.Image)(resources.GetObject("ts_Login.Image")));
            this.ts_Login.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Login.Name = "ts_Login";
            this.ts_Login.Size = new System.Drawing.Size(158, 72);
            this.ts_Login.Text = "Login";
            this.ts_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_Login.Click += new System.EventHandler(this.ts_Login_Click);
            // 
            // ts_stocks
            // 
            this.ts_stocks.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_stocks.Image = ((System.Drawing.Image)(resources.GetObject("ts_stocks.Image")));
            this.ts_stocks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_stocks.Name = "ts_stocks";
            this.ts_stocks.Size = new System.Drawing.Size(158, 65);
            this.ts_stocks.Text = "Products";
            this.ts_stocks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_stocks.Click += new System.EventHandler(this.ts_stocks_Click);
            // 
            // ts_StockOut
            // 
            this.ts_StockOut.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_StockOut.Image = ((System.Drawing.Image)(resources.GetObject("ts_StockOut.Image")));
            this.ts_StockOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_StockOut.Name = "ts_StockOut";
            this.ts_StockOut.Size = new System.Drawing.Size(158, 65);
            this.ts_StockOut.Text = "Stock-out";
            this.ts_StockOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_StockOut.Click += new System.EventHandler(this.ts_StockOut_Click);
            // 
            // ts_Return
            // 
            this.ts_Return.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Return.Image = ((System.Drawing.Image)(resources.GetObject("ts_Return.Image")));
            this.ts_Return.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Return.Name = "ts_Return";
            this.ts_Return.Size = new System.Drawing.Size(158, 65);
            this.ts_Return.Text = "Stock Return";
            this.ts_Return.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_Return.Click += new System.EventHandler(this.ts_Return_Click);
            // 
            // ts_ManageUsers
            // 
            this.ts_ManageUsers.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_ManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("ts_ManageUsers.Image")));
            this.ts_ManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_ManageUsers.Name = "ts_ManageUsers";
            this.ts_ManageUsers.Size = new System.Drawing.Size(158, 65);
            this.ts_ManageUsers.Text = "Manage Users";
            this.ts_ManageUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_ManageUsers.Click += new System.EventHandler(this.ts_ManageUsers_Click);
            // 
            // ts_Report
            // 
            this.ts_Report.Enabled = false;
            this.ts_Report.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Report.Image = ((System.Drawing.Image)(resources.GetObject("ts_Report.Image")));
            this.ts_Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_Report.Name = "ts_Report";
            this.ts_Report.Size = new System.Drawing.Size(158, 65);
            this.ts_Report.Text = "Report";
            this.ts_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_Report.Click += new System.EventHandler(this.ts_Report_Click);
            // 
            // ts_settings
            // 
            this.ts_settings.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_settings.Image = ((System.Drawing.Image)(resources.GetObject("ts_settings.Image")));
            this.ts_settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_settings.Name = "ts_settings";
            this.ts_settings.Size = new System.Drawing.Size(158, 65);
            this.ts_settings.Text = "Settings";
            this.ts_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_settings.Click += new System.EventHandler(this.ts_settings_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Login,
            this.ts_stocks,
            this.ts_StockOut,
            this.ts_Return,
            this.ts_ManageUsers,
            this.ts_suppliers,
            this.ts_Report,
            this.ts_settings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(161, 684);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_suppliers
            // 
            this.ts_suppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ts_suppliers.Font = new System.Drawing.Font("Elephant", 12F);
            this.ts_suppliers.Image = ((System.Drawing.Image)(resources.GetObject("ts_suppliers.Image")));
            this.ts_suppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_suppliers.Name = "ts_suppliers";
            this.ts_suppliers.Size = new System.Drawing.Size(158, 65);
            this.ts_suppliers.Text = "Suppliers";
            this.ts_suppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ts_suppliers.Click += new System.EventHandler(this.ts_suppliers_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1317, 684);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System | Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton ts_Login;
        private System.Windows.Forms.ToolStripButton ts_stocks;
        private System.Windows.Forms.ToolStripButton ts_StockOut;
        private System.Windows.Forms.ToolStripButton ts_Return;
        private System.Windows.Forms.ToolStripButton ts_ManageUsers;
        private System.Windows.Forms.ToolStripButton ts_Report;
        private System.Windows.Forms.ToolStripButton ts_settings;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_suppliers;
    }
}

