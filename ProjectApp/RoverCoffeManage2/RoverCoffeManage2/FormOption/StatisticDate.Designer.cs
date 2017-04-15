namespace RoverCoffeManage2
{
    partial class StatisticDate
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
            this.chartTotalStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTotalStatistics = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTotalSearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpTotalBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lb_totalPrice = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalStatistics)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartTotalStatistics
            // 
            this.chartTotalStatistics.BorderlineColor = System.Drawing.Color.Black;
            this.chartTotalStatistics.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartTotalStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalStatistics.Legends.Add(legend1);
            this.chartTotalStatistics.Location = new System.Drawing.Point(329, 68);
            this.chartTotalStatistics.Name = "chartTotalStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đồng";
            this.chartTotalStatistics.Series.Add(series1);
            this.chartTotalStatistics.Size = new System.Drawing.Size(388, 377);
            this.chartTotalStatistics.TabIndex = 9;
            this.chartTotalStatistics.Text = "chart1";
            // 
            // dgvTotalStatistics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTotalStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotalStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotalStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotalStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Penumbra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotalStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotalStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTotalStatistics.DoubleBuffered = true;
            this.dgvTotalStatistics.EnableHeadersVisualStyles = false;
            this.dgvTotalStatistics.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dgvTotalStatistics.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dgvTotalStatistics.Location = new System.Drawing.Point(0, 48);
            this.dgvTotalStatistics.Name = "dgvTotalStatistics";
            this.dgvTotalStatistics.ReadOnly = true;
            this.dgvTotalStatistics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTotalStatistics.Size = new System.Drawing.Size(310, 246);
            this.dgvTotalStatistics.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thành tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // btnTotalSearch
            // 
            this.btnTotalSearch.Depth = 0;
            this.btnTotalSearch.Icon = null;
            this.btnTotalSearch.Location = new System.Drawing.Point(3, 300);
            this.btnTotalSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTotalSearch.Name = "btnTotalSearch";
            this.btnTotalSearch.Primary = true;
            this.btnTotalSearch.Size = new System.Drawing.Size(72, 35);
            this.btnTotalSearch.TabIndex = 7;
            this.btnTotalSearch.Text = "Search";
            this.btnTotalSearch.UseVisualStyleBackColor = true;
            this.btnTotalSearch.Click += new System.EventHandler(this.btnTotalSearch_Click);
            // 
            // dtpTotalBegin
            // 
            this.dtpTotalBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dtpTotalBegin.BorderRadius = 0;
            this.dtpTotalBegin.ForeColor = System.Drawing.Color.White;
            this.dtpTotalBegin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTotalBegin.FormatCustom = null;
            this.dtpTotalBegin.Location = new System.Drawing.Point(97, 17);
            this.dtpTotalBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTotalBegin.Name = "dtpTotalBegin";
            this.dtpTotalBegin.Size = new System.Drawing.Size(144, 24);
            this.dtpTotalBegin.TabIndex = 5;
            this.dtpTotalBegin.Value = new System.DateTime(2017, 4, 2, 12, 16, 30, 22);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 44);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(386, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(321, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Theo Ngày";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.lb_totalPrice);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.materialLabel1);
            this.bunifuCards1.Controls.Add(this.dgvTotalStatistics);
            this.bunifuCards1.Controls.Add(this.btnTotalSearch);
            this.bunifuCards1.Controls.Add(this.dtpTotalBegin);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(13, 68);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(310, 377);
            this.bunifuCards1.TabIndex = 13;
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lb_totalPrice.Depth = 0;
            this.lb_totalPrice.Icon = null;
            this.lb_totalPrice.Location = new System.Drawing.Point(281, 307);
            this.lb_totalPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lb_totalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Primary = false;
            this.lb_totalPrice.Size = new System.Drawing.Size(29, 36);
            this.lb_totalPrice.TabIndex = 11;
            this.lb_totalPrice.Text = "0";
            this.lb_totalPrice.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng Doanh Thu :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 17);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Chọn ngày :";
            // 
            // StatisticDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartTotalStatistics);
            this.Name = "StatisticDate";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalStatistics)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalStatistics;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTotalStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MaterialSkin.Controls.MaterialRaisedButton btnTotalSearch;
        private Bunifu.Framework.UI.BunifuDatepicker dtpTotalBegin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton lb_totalPrice;
        private System.Windows.Forms.Label label2;
    }
}
