using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace InventorySystem1._0
{
    partial class frmReport
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnitemlisat = new System.Windows.Forms.Button();
            this.cbooption = new System.Windows.Forms.ComboBox();
            this.btnListStockin = new System.Windows.Forms.Button();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.btnStockReturn = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpto = new System.Windows.Forms.DateTimePicker();
            this.dptfrom = new System.Windows.Forms.DateTimePicker();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Panel1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.GroupBox2);
            this.Panel1.Controls.Add(this.GroupBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(218, 747);
            this.Panel1.TabIndex = 6;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnitemlisat);
            this.GroupBox2.Controls.Add(this.cbooption);
            this.GroupBox2.Controls.Add(this.btnListStockin);
            this.GroupBox2.Controls.Add(this.btnStockOut);
            this.GroupBox2.Controls.Add(this.btnStockReturn);
            this.GroupBox2.Location = new System.Drawing.Point(7, 30);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox2.Size = new System.Drawing.Size(195, 260);
            this.GroupBox2.TabIndex = 2;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Report Type";
            // 
            // btnitemlisat
            // 
            this.btnitemlisat.BackColor = System.Drawing.Color.Transparent;
            this.btnitemlisat.ForeColor = System.Drawing.Color.Black;
            this.btnitemlisat.Location = new System.Drawing.Point(12, 23);
            this.btnitemlisat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnitemlisat.Name = "btnitemlisat";
            this.btnitemlisat.Size = new System.Drawing.Size(165, 37);
            this.btnitemlisat.TabIndex = 3;
            this.btnitemlisat.Text = "List Of Items";
            this.btnitemlisat.UseVisualStyleBackColor = false;
            this.btnitemlisat.Click += new System.EventHandler(this.btnitemlisat_Click);
            // 
            // cbooption
            // 
            this.cbooption.FormattingEnabled = true;
            this.cbooption.Items.AddRange(new object[] {
            "Daily Report",
            "Weekly Report",
            "Monthly Report"});
            this.cbooption.Location = new System.Drawing.Point(12, 68);
            this.cbooption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbooption.Name = "cbooption";
            this.cbooption.Size = new System.Drawing.Size(164, 24);
            this.cbooption.TabIndex = 2;
            this.cbooption.Text = "Daily Report";
            // 
            // btnListStockin
            // 
            this.btnListStockin.BackColor = System.Drawing.Color.Transparent;
            this.btnListStockin.ForeColor = System.Drawing.Color.Black;
            this.btnListStockin.Location = new System.Drawing.Point(12, 103);
            this.btnListStockin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListStockin.Name = "btnListStockin";
            this.btnListStockin.Size = new System.Drawing.Size(165, 37);
            this.btnListStockin.TabIndex = 0;
            this.btnListStockin.Text = "List Of Stock Items";
            this.btnListStockin.UseVisualStyleBackColor = false;
            this.btnListStockin.Click += new System.EventHandler(this.btnListStockin_Click);
            // 
            // btnStockOut
            // 
            this.btnStockOut.BackColor = System.Drawing.Color.Transparent;
            this.btnStockOut.ForeColor = System.Drawing.Color.Black;
            this.btnStockOut.Location = new System.Drawing.Point(12, 148);
            this.btnStockOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(165, 37);
            this.btnStockOut.TabIndex = 0;
            this.btnStockOut.Text = "List Of Sold Items";
            this.btnStockOut.UseVisualStyleBackColor = false;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // btnStockReturn
            // 
            this.btnStockReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnStockReturn.ForeColor = System.Drawing.Color.Black;
            this.btnStockReturn.Location = new System.Drawing.Point(12, 192);
            this.btnStockReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStockReturn.Name = "btnStockReturn";
            this.btnStockReturn.Size = new System.Drawing.Size(165, 37);
            this.btnStockReturn.TabIndex = 0;
            this.btnStockReturn.Text = "List Of Returned Items";
            this.btnStockReturn.UseVisualStyleBackColor = false;
            this.btnStockReturn.Click += new System.EventHandler(this.btnStockReturn_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.dtpto);
            this.GroupBox1.Controls.Add(this.dptfrom);
            this.GroupBox1.Location = new System.Drawing.Point(7, 313);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(195, 187);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Report Date Filter";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 134);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 82);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(24, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "To";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 34);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "From";
            // 
            // dtpto
            // 
            this.dtpto.CustomFormat = "yyyy-MM-dd";
            this.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpto.Location = new System.Drawing.Point(12, 102);
            this.dtpto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpto.Name = "dtpto";
            this.dtpto.Size = new System.Drawing.Size(173, 22);
            this.dtpto.TabIndex = 2;
            // 
            // dptfrom
            // 
            this.dptfrom.CustomFormat = "yyyy-MM-dd";
            this.dptfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptfrom.Location = new System.Drawing.Point(12, 54);
            this.dptfrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dptfrom.Name = "dptfrom";
            this.dptfrom.Size = new System.Drawing.Size(173, 22);
            this.dptfrom.TabIndex = 2;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "January",
            "February",
            "March ",
            "April",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.ComboBox1.Location = new System.Drawing.Point(319, 54);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(164, 24);
            this.ComboBox1.TabIndex = 7;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 747);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.ComboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.Panel1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnitemlisat;
        internal System.Windows.Forms.ComboBox cbooption;
        internal System.Windows.Forms.Button btnListStockin;
        internal System.Windows.Forms.Button btnStockOut;
        internal System.Windows.Forms.Button btnStockReturn;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpto;
        internal System.Windows.Forms.DateTimePicker dptfrom;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;

       
    }
}