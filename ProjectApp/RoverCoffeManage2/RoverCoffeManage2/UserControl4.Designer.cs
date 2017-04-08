namespace RoverCoffeManage2
{
    partial class UserControl4
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
            ((System.ComponentModel.ISupportInitialize)(this.chartYeah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYear)).BeginInit();
            this.SuspendLayout();
            // 
            // chartYeah
            // 
            chartArea1.Name = "ChartArea1";
            this.chartYeah.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartYeah.Legends.Add(legend1);
            this.chartYeah.Location = new System.Drawing.Point(708, 78);
            this.chartYeah.Name = "chartYeah";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Đồng";
            this.chartYeah.Series.Add(series1);
            this.chartYeah.Size = new System.Drawing.Size(475, 529);
            this.chartYeah.TabIndex = 7;
            this.chartYeah.Text = "chart1";
            // 
            // dgvYear
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvYear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvYear.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvYear.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("UTM Penumbra", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYear.DoubleBuffered = true;
            this.dgvYear.EnableHeadersVisualStyles = false;
            this.dgvYear.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvYear.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dgvYear.Location = new System.Drawing.Point(43, 78);
            this.dgvYear.Name = "dgvYear";
            this.dgvYear.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvYear.Size = new System.Drawing.Size(518, 529);
            this.dgvYear.TabIndex = 6;
            // 
            // btnYearSearch
            // 
            this.btnYearSearch.Depth = 0;
            this.btnYearSearch.Icon = null;
            this.btnYearSearch.Location = new System.Drawing.Point(241, 37);
            this.btnYearSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYearSearch.Name = "btnYearSearch";
            this.btnYearSearch.Primary = true;
            this.btnYearSearch.Size = new System.Drawing.Size(125, 23);
            this.btnYearSearch.TabIndex = 5;
            this.btnYearSearch.Text = "Search";
            this.btnYearSearch.UseVisualStyleBackColor = true;
            this.btnYearSearch.Click += new System.EventHandler(this.btnYearSearch_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018"});
            this.cbYear.Location = new System.Drawing.Point(85, 37);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 4;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartYeah);
            this.Controls.Add(this.dgvYear);
            this.Controls.Add(this.btnYearSearch);
            this.Controls.Add(this.cbYear);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(1500, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.chartYeah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartYeah;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvYear;
        private MaterialSkin.Controls.MaterialRaisedButton btnYearSearch;
        private System.Windows.Forms.ComboBox cbYear;
    }
}
