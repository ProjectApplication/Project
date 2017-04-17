namespace RoverCoffeManage2
{
    partial class StatisticsQuantity
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.chartQuantityStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnQuantitySearch = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpQuantityEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpQuantityBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.dgvQuantityStatistics = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantityStatistics)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantityStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xóa Món";
            this.dataGridViewImageColumn1.Image = global::RoverCoffeManage2.Properties.Resources.del_21;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // chartQuantityStatistics
            // 
            this.chartQuantityStatistics.BorderlineColor = System.Drawing.Color.Black;
            this.chartQuantityStatistics.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartQuantityStatistics.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartQuantityStatistics.Legends.Add(legend2);
            this.chartQuantityStatistics.Location = new System.Drawing.Point(355, 68);
            this.chartQuantityStatistics.Name = "chartQuantityStatistics";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số lượng";
            this.chartQuantityStatistics.Series.Add(series2);
            this.chartQuantityStatistics.Size = new System.Drawing.Size(412, 377);
            this.chartQuantityStatistics.TabIndex = 9;
            this.chartQuantityStatistics.Text = "chart1";
            // 
            // btnQuantitySearch
            // 
            this.btnQuantitySearch.Depth = 0;
            this.btnQuantitySearch.Icon = null;
            this.btnQuantitySearch.Location = new System.Drawing.Point(3, 313);
            this.btnQuantitySearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuantitySearch.Name = "btnQuantitySearch";
            this.btnQuantitySearch.Primary = true;
            this.btnQuantitySearch.Size = new System.Drawing.Size(69, 37);
            this.btnQuantitySearch.TabIndex = 7;
            this.btnQuantitySearch.Text = "Search";
            this.btnQuantitySearch.UseVisualStyleBackColor = true;
            this.btnQuantitySearch.Click += new System.EventHandler(this.btnQuantitySearch_Click);
            // 
            // dtpQuantityEnd
            // 
            this.dtpQuantityEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dtpQuantityEnd.BorderRadius = 0;
            this.dtpQuantityEnd.ForeColor = System.Drawing.Color.White;
            this.dtpQuantityEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpQuantityEnd.FormatCustom = null;
            this.dtpQuantityEnd.Location = new System.Drawing.Point(116, 55);
            this.dtpQuantityEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpQuantityEnd.Name = "dtpQuantityEnd";
            this.dtpQuantityEnd.Size = new System.Drawing.Size(205, 28);
            this.dtpQuantityEnd.TabIndex = 6;
            this.dtpQuantityEnd.Value = new System.DateTime(2017, 4, 2, 11, 46, 32, 256);
            // 
            // dtpQuantityBegin
            // 
            this.dtpQuantityBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dtpQuantityBegin.BorderRadius = 0;
            this.dtpQuantityBegin.ForeColor = System.Drawing.Color.White;
            this.dtpQuantityBegin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpQuantityBegin.FormatCustom = null;
            this.dtpQuantityBegin.Location = new System.Drawing.Point(116, 11);
            this.dtpQuantityBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpQuantityBegin.Name = "dtpQuantityBegin";
            this.dtpQuantityBegin.Size = new System.Drawing.Size(205, 28);
            this.dtpQuantityBegin.TabIndex = 5;
            this.dtpQuantityBegin.Value = new System.DateTime(2017, 4, 2, 11, 46, 26, 983);
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
            this.label1.Location = new System.Drawing.Point(266, 3);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(551, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Theo Số Lượng Thức Uống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.dgvQuantityStatistics);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.btnQuantitySearch);
            this.bunifuCards1.Controls.Add(this.dtpQuantityBegin);
            this.bunifuCards1.Controls.Add(this.dtpQuantityEnd);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(13, 68);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(339, 377);
            this.bunifuCards1.TabIndex = 13;
            // 
            // dgvQuantityStatistics
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvQuantityStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuantityStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuantityStatistics.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvQuantityStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuantityStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuantityStatistics.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuantityStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuantityStatistics.DoubleBuffered = true;
            this.dgvQuantityStatistics.EnableHeadersVisualStyles = false;
            this.dgvQuantityStatistics.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(75)))), ((int)(((byte)(134)))));
            this.dgvQuantityStatistics.HeaderForeColor = System.Drawing.Color.White;
            this.dgvQuantityStatistics.Location = new System.Drawing.Point(-139, 90);
            this.dgvQuantityStatistics.Name = "dgvQuantityStatistics";
            this.dgvQuantityStatistics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQuantityStatistics.Size = new System.Drawing.Size(466, 217);
            this.dgvQuantityStatistics.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày kết thúc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày bắt đầu :";
            // 
            // StatisticsQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartQuantityStatistics);
            this.Name = "StatisticsQuantity";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantityStatistics)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuantityStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantityStatistics;
        private MaterialSkin.Controls.MaterialRaisedButton btnQuantitySearch;
        private Bunifu.Framework.UI.BunifuDatepicker dtpQuantityEnd;
        private Bunifu.Framework.UI.BunifuDatepicker dtpQuantityBegin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvQuantityStatistics;
    }
}
