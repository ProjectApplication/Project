namespace RoverCoffeManage2
{
    partial class StatisticYear
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chartYeah = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvYear = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnYearSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_totalPriceYear = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartYeah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYear)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartYeah
            // 
            this.chartYeah.BorderlineColor = System.Drawing.Color.Black;
            this.chartYeah.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartYeah.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYeah.Legends.Add(legend1);
            this.chartYeah.Location = new System.Drawing.Point(360, 68);
            this.chartYeah.Name = "chartYeah";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đồng";
            this.chartYeah.Series.Add(series1);
            this.chartYeah.Size = new System.Drawing.Size(412, 377);
            this.chartYeah.TabIndex = 7;
            this.chartYeah.Text = "chart1";
            // 
            // dgvYear
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvYear.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvYear.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Penumbra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYear.DoubleBuffered = true;
            this.dgvYear.EnableHeadersVisualStyles = false;
            this.dgvYear.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dgvYear.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dgvYear.Location = new System.Drawing.Point(3, 59);
            this.dgvYear.Name = "dgvYear";
            this.dgvYear.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvYear.Size = new System.Drawing.Size(322, 246);
            this.dgvYear.TabIndex = 6;
            // 
            // btnYearSearch
            // 
            this.btnYearSearch.Depth = 0;
            this.btnYearSearch.Icon = null;
            this.btnYearSearch.Location = new System.Drawing.Point(3, 311);
            this.btnYearSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYearSearch.Name = "btnYearSearch";
            this.btnYearSearch.Primary = true;
            this.btnYearSearch.Size = new System.Drawing.Size(79, 45);
            this.btnYearSearch.TabIndex = 5;
            this.btnYearSearch.Text = "Search";
            this.btnYearSearch.UseVisualStyleBackColor = true;
            this.btnYearSearch.Click += new System.EventHandler(this.btnYearSearch_Click);
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018"});
            this.cbYear.Location = new System.Drawing.Point(18, 32);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(207, 21);
            this.cbYear.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(221, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Chọn năm muốn xem thống kê :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 44);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(386, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(314, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Theo Năm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lb_totalPriceYear);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.materialLabel1);
            this.bunifuCards1.Controls.Add(this.btnYearSearch);
            this.bunifuCards1.Controls.Add(this.dgvYear);
            this.bunifuCards1.Controls.Add(this.cbYear);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(13, 68);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(341, 377);
            this.bunifuCards1.TabIndex = 12;
            // 
            // lb_totalPriceYear
            // 
            this.lb_totalPriceYear.AutoSize = true;
            this.lb_totalPriceYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lb_totalPriceYear.Depth = 0;
            this.lb_totalPriceYear.Icon = null;
            this.lb_totalPriceYear.Location = new System.Drawing.Point(296, 320);
            this.lb_totalPriceYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lb_totalPriceYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_totalPriceYear.Name = "lb_totalPriceYear";
            this.lb_totalPriceYear.Primary = false;
            this.lb_totalPriceYear.Size = new System.Drawing.Size(29, 36);
            this.lb_totalPriceYear.TabIndex = 13;
            this.lb_totalPriceYear.Text = "0";
            this.lb_totalPriceYear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng Doanh Thu :";
            // 
            // StatisticYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartYeah);
            this.Name = "StatisticYear";
            this.Size = new System.Drawing.Size(1366, 737);
            ((System.ComponentModel.ISupportInitialize)(this.chartYeah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYear)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartYeah;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvYear;
        private MaterialSkin.Controls.MaterialRaisedButton btnYearSearch;
        private System.Windows.Forms.ComboBox cbYear;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialFlatButton lb_totalPriceYear;
        private System.Windows.Forms.Label label3;
    }
}
