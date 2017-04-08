namespace RoverCoffeManage2
{
    partial class UserControl2
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
            this.dtpTotalEnd = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpTotalBegin = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTotalStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTotalStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTotalStatistics.Legends.Add(legend1);
            this.chartTotalStatistics.Location = new System.Drawing.Point(608, 177);
            this.chartTotalStatistics.Name = "chartTotalStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đồng";
            this.chartTotalStatistics.Series.Add(series1);
            this.chartTotalStatistics.Size = new System.Drawing.Size(850, 477);
            this.chartTotalStatistics.TabIndex = 9;
            this.chartTotalStatistics.Text = "chart1";
            // 
            // dgvTotalStatistics
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTotalStatistics.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotalStatistics.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTotalStatistics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTotalStatistics.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
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
            this.dgvTotalStatistics.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvTotalStatistics.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dgvTotalStatistics.Location = new System.Drawing.Point(30, 177);
            this.dgvTotalStatistics.Name = "dgvTotalStatistics";
            this.dgvTotalStatistics.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTotalStatistics.Size = new System.Drawing.Size(401, 477);
            this.dgvTotalStatistics.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thành tiền";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // btnTotalSearch
            // 
            this.btnTotalSearch.Depth = 0;
            this.btnTotalSearch.Icon = null;
            this.btnTotalSearch.Location = new System.Drawing.Point(122, 132);
            this.btnTotalSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTotalSearch.Name = "btnTotalSearch";
            this.btnTotalSearch.Primary = true;
            this.btnTotalSearch.Size = new System.Drawing.Size(148, 23);
            this.btnTotalSearch.TabIndex = 7;
            this.btnTotalSearch.Text = "Search";
            this.btnTotalSearch.UseVisualStyleBackColor = true;
            this.btnTotalSearch.Click += new System.EventHandler(this.btnTotalSearch_Click);
            // 
            // dtpTotalEnd
            // 
            this.dtpTotalEnd.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpTotalEnd.BorderRadius = 0;
            this.dtpTotalEnd.ForeColor = System.Drawing.Color.White;
            this.dtpTotalEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTotalEnd.FormatCustom = null;
            this.dtpTotalEnd.Location = new System.Drawing.Point(78, 78);
            this.dtpTotalEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTotalEnd.Name = "dtpTotalEnd";
            this.dtpTotalEnd.Size = new System.Drawing.Size(303, 36);
            this.dtpTotalEnd.TabIndex = 6;
            this.dtpTotalEnd.Value = new System.DateTime(2017, 4, 2, 12, 16, 41, 360);
            // 
            // dtpTotalBegin
            // 
            this.dtpTotalBegin.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpTotalBegin.BorderRadius = 0;
            this.dtpTotalBegin.ForeColor = System.Drawing.Color.White;
            this.dtpTotalBegin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTotalBegin.FormatCustom = null;
            this.dtpTotalBegin.Location = new System.Drawing.Point(78, 34);
            this.dtpTotalBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTotalBegin.Name = "dtpTotalBegin";
            this.dtpTotalBegin.Size = new System.Drawing.Size(303, 36);
            this.dtpTotalBegin.TabIndex = 5;
            this.dtpTotalBegin.Value = new System.DateTime(2017, 4, 2, 12, 16, 30, 22);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartTotalStatistics);
            this.Controls.Add(this.dgvTotalStatistics);
            this.Controls.Add(this.btnTotalSearch);
            this.Controls.Add(this.dtpTotalEnd);
            this.Controls.Add(this.dtpTotalBegin);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTotalStatistics;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTotalStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private MaterialSkin.Controls.MaterialRaisedButton btnTotalSearch;
        private Bunifu.Framework.UI.BunifuDatepicker dtpTotalEnd;
        private Bunifu.Framework.UI.BunifuDatepicker dtpTotalBegin;
    }
}
